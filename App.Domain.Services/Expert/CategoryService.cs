using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Domain.Core.Expert.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Expert
{
    public class CategoryService : ICategoryService
    {
        #region Fields
        private readonly ICategoryRepository _categoryRepository;
        #endregion

        #region Ctors
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion

        #region Implementations
        public async Task<Category> CreateCategory(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            var creatingCategory = new Category();
            creatingCategory.CreatedAt = DateTime.Now;
            creatingCategory.Title = categoryDto.Title;
            creatingCategory.Description = categoryDto.Description;
            creatingCategory.Image = categoryDto.Image;
            return await _categoryRepository.CreateCategory(creatingCategory, cancellationToken);
        }

        public async Task<List<CategoryDto>> GetCategories(CancellationToken cancellationToken)
            => await _categoryRepository.GetCategories(cancellationToken);

        public async Task<List<CategoryDto>> GetCategoriesWithServices(CancellationToken cancellationToken)
            => await _categoryRepository.GetCategoriesWithServices(cancellationToken);

        public async Task<CategoryDto> GetCategoryById(int categoryId, CancellationToken cancellationToken)
            => await _categoryRepository.GetCategoryById(categoryId, cancellationToken);

        public async Task<bool> RestoreDeletedCategory(int categoryId, CancellationToken cancellationToken)
            => await _categoryRepository.RestoreDeletedCategory(categoryId, cancellationToken);

        //public async Task<Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken)
        //    => await _categoryRepository.HardDeleteCategory(categoryId, cancellationToken);

        public async Task<CategorySoftDeleteDto> SoftDeleteCategory(int categoryId, CancellationToken cancellationToken)
            => await _categoryRepository.SoftDeleteCategory(categoryId, cancellationToken);

        public async Task<CategoryDto> UpdateCategory(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            var updatedCategory = new Category();
            updatedCategory.Id = categoryDto.Id;
            updatedCategory.Title = categoryDto.Title;
            updatedCategory.Description = categoryDto.Description;
            updatedCategory.Image = categoryDto.Image;
            return await _categoryRepository.UpdateCategory(updatedCategory, cancellationToken);
        }

        #endregion
    }
}
