using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Data
{
    public interface ICommentRepository
    {
        public Task<Customer.Entities.Comment> CreateComment(Customer.Entities.Comment submittedComment, CancellationToken cancellationToken);
        public Task<CommentDto> UpdateComment(Customer.Entities.Comment updatedComment, CancellationToken cancellationToken);
        public Task<CommentSoftDeleteDto> SoftDeleteComment(int commentId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken);
        public Task<CommentDto> GetCommentById(int commentId, CancellationToken cancellationToken);
        public Task<List<CommentDto>> GetComments(CancellationToken cancellationToken);
        public Task<CommentDto> ConfirmComment(int commentId, CancellationToken cancellationToken);
        public Task<List<CommentDto>> GetCommentsByExpertId(int expertId, int onlineCutomerId, CancellationToken cancellationToken);
        public Task<CommentDto> GetCustomerCommentByServiceRequestId(int customerId, int serviceRequestId, CancellationToken cancellationToken);
    }
}
