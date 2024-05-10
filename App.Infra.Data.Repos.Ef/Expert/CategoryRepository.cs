using App.Domain.Core.Admin.DTOs;
using App.Domain.Core.Admin.Entities;
using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.DTOs;
using App.Domain.Core.Expert.Entities;
using App.Infra.Data.Repos.Ef.Admin;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Infra.Data.Repos.Ef.Expert
{
    public class CategoryRepository : ICategoryRepository
    {
        #region Fields
        private readonly HomeServiceDbContext _homeServiceDbContext;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<CategoryRepository> _logger;
        #endregion

        #region Ctors
        public CategoryRepository(HomeServiceDbContext homeServiceDbContext,
            IMemoryCache memoryCache,
            ILogger<CategoryRepository> logger)
        {
            _homeServiceDbContext = homeServiceDbContext;
            _memoryCache = memoryCache;
            _logger = logger;
        }
        #endregion

        #region Implementations
        public async Task<Category> CreateCategory(Category createdCategory, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Categories.AddAsync(createdCategory, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Category has been successfully added to the database.");
            return createdCategory;
        }

        public async Task<List<CategoryDto>> GetCategories(CancellationToken cancellationToken)
        {
            var categories = _memoryCache.Get<List<CategoryDto>>("categoryDtos");

            if (categories is null)
            {
                categories = await _homeServiceDbContext.Categories
                .Select(a => new CategoryDto()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                }).ToListAsync(cancellationToken);

                if (categories is null)
                {
                    _logger.LogError("We expected the AdminProfileDtos to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
                else
                {
                    _memoryCache.Set("categoryDtos", categories, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("categoryDtos returned from database, and cached in memory successfully.");
                    return categories;
                }
            }
            _logger.LogInformation("categoryDtos returned from InMemoryCache.");
            return categories;
        }
        //{
        //    var categories = await _homeServiceDbContext.Categories.ToListAsync(cancellationToken);
        //    if (categories != null)
        //    {
        //        return categories;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<CategoryDto> GetCategoryById(int categoryId, CancellationToken cancellationToken)
        {
            var category = _memoryCache.Get<CategoryDto>("categoryDto");
            if (category is null)
            {
                category = await _homeServiceDbContext.Categories
                .Select(a => new Domain.Core.Expert.DTOs.CategoryDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                }).FirstOrDefaultAsync(a => a.Id == categoryId, cancellationToken);

                if (category != null)
                {
                    _memoryCache.Set("categoryDto", category, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("categoryDto returned from database, and cached in memory successfully.");
                    return category;
                }
                else
                {
                    _logger.LogError("We expected the categoryDto to return from the database, but it returned null.");
                    throw new Exception("Something wents wrong!, please try again.");
                }
            }
            _logger.LogInformation("categoryDto returned from InMemoryCache.");
            return category;
        }

        //public async Task<Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken)
        //{
        //    var deletedCategory = await GetCategory(categoryId, cancellationToken);
        //    if (deletedCategory != null)
        //    {
        //        deletedCategory.IsDeleted = true;
        //        _homeServiceDbContext.Categories.Remove(deletedCategory);
        //        await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
        //        return deletedCategory;
        //    }
        //    else
        //    {
        //        //throw an exception - will be implement!
        //        throw new InvalidOperationException();
        //    }
        //}

        public async Task<CategorySoftDeleteDto> SoftDeleteCategory(int categoryId, CancellationToken cancellationToken)
        {
            var deletedCategory = await GetCategorySoftDeleteDto(categoryId, cancellationToken);
            deletedCategory.IsDeleted = true;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return deletedCategory;
        }

        public async Task<CategoryDto> UpdateCategory(Category updatedCategory, CancellationToken cancellationToken)
        {
            var updatingCategory = await GetCategoryDto(updatedCategory.Id, cancellationToken);
            updatingCategory.Title = updatedCategory.Title;
            updatingCategory.Description = updatedCategory.Description;
            updatingCategory.Image = updatedCategory.Image;
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return updatingCategory;
        }
        #endregion

        #region PrivateMethods
        private async Task<CategoryDto> GetCategoryDto(int categoryId, CancellationToken cancellationToken)
        {
            var category = _memoryCache.Get<CategoryDto>("categoryDto");
            if (category is null)
            {
                category = await _homeServiceDbContext.Categories
                .Select(a => new CategoryDto()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                }).FirstOrDefaultAsync(a => a.Id == categoryId, cancellationToken);

                if (category != null)
                {
                    _memoryCache.Set("categoryDto", category, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("categoryDto has been returned form database and cached in memory successfully.");
                    return category;
                }
                _logger.LogError($"category with id {categoryId} not found in GetCategoryDto method.");
                throw new Exception($"category with id {categoryId} not found.");
            }
            _logger.LogInformation("categoryDto returned from InMemeoryCache in GetCategoryDto method.");
            return category;
        }

        private async Task<CategorySoftDeleteDto> GetCategorySoftDeleteDto(int categoryId, CancellationToken cancellationToken)
        {
            var category = _memoryCache.Get<CategorySoftDeleteDto>("categorySoftDeleteDto");
            if (category is null)
            {
                category = await _homeServiceDbContext.Categories
                .Select(a => new CategorySoftDeleteDto()
                {
                    Id = a.Id,
                    IsDeleted = a.IsDeleted
                }).FirstOrDefaultAsync(a => a.Id == categoryId, cancellationToken);

                if (category != null)
                {
                    _memoryCache.Set("categorySoftDeleteDto", category, new MemoryCacheEntryOptions()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(120)
                    });
                    _logger.LogInformation("categorySoftDeleteDto has been returned form database and cached in memory successfully.");
                    return category;
                }
                _logger.LogError($"category with id {categoryId} not found in GetCategorySoftDeleteDto method.");
                throw new Exception($"category with id {categoryId} not found.");
            }
            _logger.LogInformation("categorySoftDeleteDto returned from InMemeoryCache in GetCategorySoftDeleteDto method.");
            return category;

        }
        #endregion
    }
}
