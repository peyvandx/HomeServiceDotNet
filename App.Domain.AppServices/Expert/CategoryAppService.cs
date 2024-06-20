using App.Domain.Core.Expert.AppServices;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class CategoryAppService : ICategoryAppService
    {
        #region Fields
        private readonly ICategoryService _categoryService;
        #endregion

        #region Ctors
        public CategoryAppService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion

        #region Implementations
        public async Task<Category> CreateCategory(CategoryDto categoryDto, CancellationToken cancellationToken)
            => await _categoryService.CreateCategory(categoryDto, cancellationToken);

        public async Task<List<CategoryDto>> GetCategories(CancellationToken cancellationToken)
            => await _categoryService.GetCategories(cancellationToken);

        public async Task<List<CategoryDto>> GetCategoriesWithServices(CancellationToken cancellationToken)
            => await _categoryService.GetCategoriesWithServices(cancellationToken);

        public async Task<CategoryDto> GetCategoryById(int categoryId, CancellationToken cancellationToken)
            => await _categoryService.GetCategoryById(categoryId, cancellationToken);

        public async Task<bool> RestoreDeletedCategory(int categoryId, CancellationToken cancellationToken)
            => await _categoryService.RestoreDeletedCategory(categoryId, cancellationToken);

        //public async Task<Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken)
        //    => await _categoryService.HardDeleteCategory(categoryId, cancellationToken);

        public async Task<CategorySoftDeleteDto> SoftDeleteCategory(int categoryId, CancellationToken cancellationToken)
            => await _categoryService.SoftDeleteCategory(categoryId, cancellationToken);

        public async Task<CategoryDto> UpdateCategory(CategoryDto categoryDto, CancellationToken cancellationToken)
            => await _categoryService.UpdateCategory(categoryDto, cancellationToken);

        #endregion
    }
}
