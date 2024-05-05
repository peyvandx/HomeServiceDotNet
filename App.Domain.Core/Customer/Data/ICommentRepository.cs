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
        public Task<Customer.Entities.Comment> UpdateComment(Customer.Entities.Comment updatedComment, CancellationToken cancellationToken);
        public Task<Customer.Entities.Comment> SoftDeleteComment(int commentId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken);
        public Task<Customer.Entities.Comment> GetCommentById(int commentId, CancellationToken cancellationToken);
        public Task<List<Customer.Entities.Comment>> GetComments(CancellationToken cancellationToken);
    }
}
