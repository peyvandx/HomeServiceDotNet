using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class CommentRepository : ICommentRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        #endregion

        #region Ctors
        public CommentRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<Comment> CreateComment(Comment submittedComment, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Comments.AddAsync(submittedComment, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return submittedComment;
        }

        public async Task<Comment> GetCommentById(int commentId, CancellationToken cancellationToken)
        {
            var comment = await _homeServiceDbContext.Comments.FirstOrDefaultAsync(c => c.Id == commentId, cancellationToken);
            if (comment != null)
            {
                return comment;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<List<Comment>> GetComments(CancellationToken cancellationToken) => await _homeServiceDbContext.Comments.ToListAsync(cancellationToken);
        //{
        //    var comments = _homeServiceDbContext.Comments.ToList();
        //    if (comments != null)
        //    {
        //        return comments;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken)
        {
            var deletedComment = await GetComment(commentId, cancellationToken);
            if (deletedComment != null)
            {
                deletedComment.IsDeleted = true;
                _homeServiceDbContext.Comments.Remove(deletedComment);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedComment;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Comment> SoftDeleteComment(int commentId, CancellationToken cancellationToken)
        {
            var deletedComment = await GetComment(commentId, cancellationToken);
            if (deletedComment != null)
            {
                deletedComment.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedComment;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Comment> UpdateComment(Comment updatedComment, CancellationToken cancellationToken)
        {
            var updatingComment = await GetComment(updatedComment.Id, cancellationToken);
            if (updatingComment != null)
            {
                updatingComment.Description = updatedComment.Description;
                updatingComment.Rate = updatedComment.Rate;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingComment;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Customer.Entities.Comment> GetComment(int commentId, CancellationToken cancellationToken)
        {
            var comment = await _homeServiceDbContext.Comments
                .FirstOrDefaultAsync(a => a.Id == commentId, cancellationToken);

            if (comment != null)
            {
                return comment;
            }

            throw new Exception($"comment with id {commentId} not found");
        }
        #endregion
    }
}
