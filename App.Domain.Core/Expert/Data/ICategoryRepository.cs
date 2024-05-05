using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Data
{
    public interface ICategoryRepository
    {
        public Task<Expert.Entities.Category> CreateCategory(Expert.Entities.Category createdCategory, CancellationToken cancellationToken);
        public Task<Expert.Entities.Category> UpdateCategory(Expert.Entities.Category updatedCategory, CancellationToken cancellationToken);
        public Task<Expert.Entities.Category> SoftDeleteCategory(int categoryId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Category> GetCategoryById(int categoryId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Category>> GetCategories(CancellationToken cancellationToken);
    }
}
