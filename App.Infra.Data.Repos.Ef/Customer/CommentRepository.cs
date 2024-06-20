using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Customer
{
    public class CommentRepository : ICommentRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<CommentRepository> _logger;
        #endregion

        #region Ctors
        public CommentRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<CommentRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Comment> CreateComment(Comment submittedComment, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Comments.AddAsync(submittedComment, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Comment has been successfully added to the database.");
            return submittedComment;
        }

        public async Task<List<CommentDto>> GetCommentsByExpertId(int expertId, int onlineCutomerId, CancellationToken cancellationToken)
        {
            return await _homeServiceDbContext.Comments
                .Where(c => c.ExpertId == expertId && c.IsDeleted == false && c.IsConfirmed == true && c.CustomerId != onlineCutomerId)
                .Include(c => c.Customer)
                .Include(c => c.ServiceRequest)
                .ThenInclude(sr => sr.Service)
                .Select(c => new CommentDto
                {
                    Id = c.Id,
                    CustomerName = c.Customer.FirstName + " " + c.Customer.LastName,
                    Description = c.Description,
                    Rate = c.Rate,
                    CreationDate = c.CreateDate,
                    CustomerImageUrl = c.Customer.ProfileImage,
                    ServiceName = c.ServiceRequest.Service.Title
                }).ToListAsync(cancellationToken);
        }

        public async Task<CommentDto> GetCustomerCommentByServiceRequestId(int customerId, int serviceRequestId, CancellationToken cancellationToken)
        {
            var customerComment = await _homeServiceDbContext.Comments
                .Where(c => c.CustomerId == customerId && c.ServiceRequestId == serviceRequestId)
                .Include(c => c.Customer)
                .Select(c => new CommentDto
                {
                    Id= c.Id,
                    Description = c.Description,
                    Rate = c.Rate,
                    CreationDate = c.CreateDate,
                    IsConfirmed = c.IsConfirmed,
                    CustomerImageUrl = c.Customer.ProfileImage,
                    IsDeleted = c.IsDeleted
                }).FirstOrDefaultAsync(cancellationToken);

            if (customerComment == null)
            {
                _logger.LogError($"Customer Comment Returned Null From Data Base!. CustomerId{customerId}, ExpertId{serviceRequestId}.");
                //we can throw error?!
            }

            return customerComment;
        }

        public async Task<CommentDto> GetCommentById(int commentId, CancellationToken cancellationToken)
        {
            var comment = _memoryCache.Get<CommentDto>("commentDto");
            if (comment is null)
            {
                comment = await _homeServiceDbContext.Comments
                .Select(c => new CommentDto
                {
                    Id = c.Id,
                    Description = c.Description,
                    Rate = c.Rate,
                    CustomerId = c.CustomerId,
                    CustomerName = c.Customer.FirstName + " " + c.Customer.LastName,
                    ExpertId = c.ExpertId,
                    ExpertName = c.Expert.FirstName + " " + c.Expert.LastName,
                    //AdminId = c.AdminId,
                    //AdminName = c.Admin.FirstName + " " + c.Admin.LastName,
                }).FirstOrDefaultAsync(c => c.Id == commentId, cancellationToken);

                if (comment != null)
                {
                    _memoryCache.Set("commentDto", comment, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("commentDto returned from database, and cached in memory successfully.");
                    return comment;
                }
                else
                {
                    _logger.LogError("We expected the commentDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("commentDto returned from InMemoryCache.");
            return comment;
        }

        public async Task<List<CommentDto>> GetComments(CancellationToken cancellationToken)
        {
            var comments = _memoryCache.Get<List<CommentDto>>("commentDtos");

            if (comments is null)
            {
                comments = await _homeServiceDbContext.Comments
                 .Select(c => new CommentDto
                 {
                     Id = c.Id,
                     Description = c.Description,
                     Rate = c.Rate,
                     CustomerId = c.CustomerId,
                     CustomerName = c.Customer.FirstName + " " + c.Customer.LastName,
                     ExpertId = c.ExpertId,
                     ExpertName = c.Expert.FirstName + " " + c.Expert.LastName,
                     //AdminId = c.AdminId,
                     //AdminName = c.Admin.FirstName + " " + c.Admin.LastName,
                     IsConfirmed = c.IsConfirmed,
                     IsDeleted  = c.IsDeleted,
                 }).ToListAsync(cancellationToken);

                if (comments is null)
                {
                    _logger.LogError("We expected the AdminProfileDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("commentDtos", comments, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("commentDtos returned from database, and cached in memory successfully.");
                    return comments;
                }
            }
            _logger.LogInformation("commentDtos returned from InMemoryCache.");
            return comments;
        }

        //public async Task<Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken)
        //{
        //    var deletedComment = await GetComment(commentId, cancellationToken);
        //    if (deletedComment != null)
        //    {
        //        deletedComment.IsDeleted = true;
        //        _homeServiceDbContext.Comments.Remove(deletedComment);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedComment;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<CommentSoftDeleteDto> SoftDeleteComment(int commentId, CancellationToken cancellationToken)
        {
            var deletedComment = await GetCommentSoftDeleteDto(commentId, cancellationToken);
            deletedComment.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            _memoryCache.Remove("commentDtos");

            var CommentSoftDeleteDto = new CommentSoftDeleteDto();
            CommentSoftDeleteDto.IsDeleted = deletedComment.IsDeleted;
            return CommentSoftDeleteDto;
        }

        public async Task<CommentDto> UpdateComment(Comment updatedComment, CancellationToken cancellationToken)
        {
            var updatingComment = await GetCommentDto(updatedComment.Id, cancellationToken);
            if (updatingComment != null)
            {
                updatingComment.Description = updatedComment.Description;
                updatingComment.Rate = updatedComment.Rate;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

                _memoryCache.Remove("commentDtos");

                var updatingCommentDto = new CommentDto();
                updatingCommentDto.Description = updatingComment.Description;
                updatingCommentDto.Rate = updatedComment.Rate;
                return updatingCommentDto;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<CommentDto> ConfirmComment(int  commentId, CancellationToken cancellationToken)
        {
            var confirmingComment = await GetCommentDto(commentId, cancellationToken);
            confirmingComment.IsConfirmed = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);

            _memoryCache.Remove("commentDtos");

            var confirmedComment = new CommentDto();
            confirmedComment.Description = confirmingComment.Description;
            confirmedComment.IsConfirmed = confirmingComment.IsConfirmed;
            confirmedComment.IsDeleted = confirmingComment.IsDeleted;
            confirmedComment.Rate = confirmingComment.Rate;
            return confirmedComment;
        }
        #endregion

        #region PrivateMethods
        private async Task<Comment> GetCommentDto(int commentId, CancellationToken cancellationToken)
        {
            var comment = _memoryCache.Get<Comment>("comment");
            if (comment is null)
            {
                comment = await _homeServiceDbContext.Comments
                .FirstOrDefaultAsync(c => c.Id == commentId, cancellationToken);

                if (comment != null)
                {
                    _memoryCache.Set("comment", comment, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("commentDto has been returned form database and cached in memory successfully.");
                    return comment;
                }
                _logger.LogError($"comment with id {commentId} not found in GetCommentDto method.");
                throw new Exception($"comment with id {commentId} not found.");
            }
            _logger.LogInformation("commentDto returned from InMemeoryCache in GetCommentDto method.");
            return comment;
        }

        private async Task<Comment> GetCommentSoftDeleteDto(int commentId, CancellationToken cancellationToken)
        {
            var comment = _memoryCache.Get<Comment>("commentSoftDelete");
            if (comment is null)
            {
                comment = await _homeServiceDbContext.Comments
                .FirstOrDefaultAsync(a => a.Id == commentId, cancellationToken);

                if (comment != null)
                {
                    _memoryCache.Set("commentSoftDelete", comment, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("commentSoftDelete has been returned form database and cached in memory successfully.");
                    return comment;
                }
                _logger.LogError($"comment with id {commentId} not found in GetCommentSoftDeleteDto method.");
                throw new Exception($"comment with id {commentId} not found.");
            }
            _logger.LogInformation("commentSoftDeleteDto returned from InMemeoryCache in GetCommentSoftDeleteDto method.");
            return comment;

        }

        #endregion
    }
}
