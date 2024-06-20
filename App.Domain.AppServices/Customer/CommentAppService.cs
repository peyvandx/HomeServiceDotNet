using App.Domain.Core.Customer.AppServices;
using App.Domain.Core.Customer.DTOs;
using App.Domain.Core.Customer.Entities;
using App.Domain.Core.Customer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class CommentAppService : ICommentAppService
    {
        #region Fields
        private readonly ICommentService _commentService;
        #endregion

        #region Ctors
        public CommentAppService(ICommentService commentService)
        {
            _commentService = commentService;
        }
        #endregion

        #region Implementations
        public async Task<Comment> CreateComment(CommentDto commentDto, CancellationToken cancellationToken)
            => await _commentService.CreateComment(commentDto, cancellationToken);

        public Task<CommentDto> GetCommentById(int commentId, CancellationToken cancellationToken)
            => _commentService.GetCommentById(commentId, cancellationToken);

        public Task<List<CommentDto>> GetComments(CancellationToken cancellationToken)
            => _commentService.GetComments(cancellationToken);

        //public Task<Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken)
        //    => _commentService.HardDeleteComment(commentId, cancellationToken);

        public Task<CommentSoftDeleteDto> SoftDeleteComment(int commentId, CancellationToken cancellationToken)
            => _commentService.SoftDeleteComment(commentId, cancellationToken);

        public Task<CommentDto> UpdateComment(CommentDto commentDto, CancellationToken cancellationToken)
            => _commentService.UpdateComment(commentDto, cancellationToken);

        public async Task<CommentDto> ConfirmComment(int commentId, CancellationToken cancellationToken)
            => await _commentService.ConfirmComment(commentId, cancellationToken);

        public async Task<List<CommentDto>> GetCommentsByExpertId(int expertId, int onlineCutomerId, CancellationToken cancellationToken)
            => await _commentService.GetCommentsByExpertId(expertId, onlineCutomerId, cancellationToken);

        public async Task<CommentDto> GetCustomerCommentByServiceRequestId(int customerId, int serviceRequestId, CancellationToken cancellationToken)
            => await _commentService.GetCustomerCommentByServiceRequestId(customerId, serviceRequestId, cancellationToken);
        #endregion
    }
}
