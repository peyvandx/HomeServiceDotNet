using App.Domain.Core.Expert.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Services
{
    public interface ICategoryService
    {
        public Task<Expert.Entities.Category> CreateCategory(CategoryDto categoryDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Category> UpdateCategory(CategoryDto categoryDto, CancellationToken cancellationToken);
        public Task<Expert.Entities.Category> SoftDeleteCategory(int categoryId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken);
        public Task<Expert.Entities.Category> GetCategoryById(int categoryId, CancellationToken cancellationToken);
        public Task<List<Expert.Entities.Category>> GetCategories(CancellationToken cancellationToken);
    }
}
