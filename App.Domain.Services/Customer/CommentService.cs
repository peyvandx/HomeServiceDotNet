using App.Domain.Core.Customer.Data;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Customer
{
    public class CommentService : ICommentService
    {
        #region Fields
        private readonly ICommentRepository _commentRepository;
        #endregion

        #region Ctors
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        #endregion

        #region Implementations
        public async Task<Comment> CreateComment(CommentDto commentDto, CancellationToken cancellationToken)
        {
            var submittedComment = new Comment();
            submittedComment.CreateDate = DateTime.Now;
            submittedComment.Description = commentDto.Description;
            submittedComment.Rate = commentDto.Rate;
            submittedComment.CustomerId = commentDto.CustomerId;
            submittedComment.ExpertId = commentDto.ExpertId;
            submittedComment.ServiceRequestId = commentDto.ServiceRequestId;
            return await _commentRepository.CreateComment(submittedComment, cancellationToken);
        }

        public async Task<CommentDto> GetCommentById(int commentId, CancellationToken cancellationToken)
            => await _commentRepository.GetCommentById(commentId, cancellationToken);

        public async Task<List<CommentDto>> GetComments(CancellationToken cancellationToken)
            => await _commentRepository.GetComments(cancellationToken);

        //public async Task<Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken)
        //    => await _commentRepository.HardDeleteComment(commentId, cancellationToken);

        public async Task<CommentSoftDeleteDto> SoftDeleteComment(int commentId, CancellationToken cancellationToken)
            => await _commentRepository.SoftDeleteComment(commentId, cancellationToken);

        public async Task<CommentDto> UpdateComment(CommentDto commentDto, CancellationToken cancellationToken)
        {
            var updatedComment = new Comment();
            updatedComment.Description = commentDto.Description;
            updatedComment.Rate = commentDto.Rate;
            return await _commentRepository.UpdateComment(updatedComment, cancellationToken);
        }

        public async Task<CommentDto> ConfirmComment(int commentId, CancellationToken cancellationToken)
            => await _commentRepository.ConfirmComment(commentId, cancellationToken);

        public async Task<List<CommentDto>> GetCommentsByExpertId(int expertId, int onlineCutomerId, CancellationToken cancellationToken)
            => await _commentRepository.GetCommentsByExpertId(expertId, onlineCutomerId, cancellationToken);

        public async Task<CommentDto> GetCustomerCommentByServiceRequestId(int customerId, int serviceRequestId, CancellationToken cancellationToken)
            => await _commentRepository.GetCustomerCommentByServiceRequestId(customerId, serviceRequestId, cancellationToken);
        #endregion
    }
}
