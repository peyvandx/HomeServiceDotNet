using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class CategoryAppService : ICategoryAppService
    {
        public Task<Category> CreateCategory(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategories(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryById(int categoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Category> SoftDeleteCategory(int categoryId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateCategory(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
