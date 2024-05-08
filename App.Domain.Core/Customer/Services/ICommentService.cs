using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Services
{
    public interface ICommentService
    {
        public Task<Customer.Entities.Comment> CreateComment(CommentDto commentDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.Comment> UpdateComment(CommentDto commentDto, CancellationToken cancellationToken);
        public Task<Customer.Entities.Comment> SoftDeleteComment(int commentId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Comment> GetCommentById(int commentId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.Comment>> GetComments(CancellationToken cancellationToken);
    }
}
