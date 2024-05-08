using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class CommentAppService : ICommentAppService
    {
        public Task<Comment> CreateComment(CommentDto commentDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentById(int commentId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetComments(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> SoftDeleteComment(int commentId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateComment(CommentDto commentDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
