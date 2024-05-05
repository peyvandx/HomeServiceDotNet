using App.Domain.Core.Expert.Data;
using App.Domain.Core.Expert.Entities;
using App.Infra.Db.SqlServer.Ef.DbContext;
using Microsoft.EntityFrameworkCore;
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
        #endregion

        #region Ctors
        public CategoryRepository(HomeServiceDbContext homeServiceDbContext)
        {
            _homeServiceDbContext = homeServiceDbContext;
        }
        #endregion

        #region Implementations
        public async Task<Category> CreateCategory(Category createdCategory, CancellationToken cancellationToken)
        {
            await _homeServiceDbContext.Categories.AddAsync(createdCategory, cancellationToken);
            await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
            return createdCategory;
        }

        public async Task<List<Category>> GetCategories(CancellationToken cancellationToken) => await _homeServiceDbContext.Categories.ToListAsync(cancellationToken);
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

        public async Task<Category> GetCategoryById(int categoryId, CancellationToken cancellationToken)
        {
            var category = await _homeServiceDbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId, cancellationToken);
            if (category != null)
            {
                return category;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Category> HardDeleteCategory(int categoryId, CancellationToken cancellationToken)
        {
            var deletedCategory = await GetCategory(categoryId, cancellationToken);
            if (deletedCategory != null)
            {
                deletedCategory.IsDeleted = true;
                _homeServiceDbContext.Categories.Remove(deletedCategory);
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedCategory;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Category> SoftDeleteCategory(int categoryId, CancellationToken cancellationToken)
        {
            var deletedCategory = await GetCategory(categoryId, cancellationToken);
            if (deletedCategory != null)
            {
                deletedCategory.IsDeleted = true;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return deletedCategory;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }

        public async Task<Category> UpdateCategory(Category updatedCategory, CancellationToken cancellationToken)
        {
            var updatingCategory = await GetCategory(updatedCategory.Id, cancellationToken);
            if (updatingCategory != null)
            {
                updatingCategory.Title = updatedCategory.Title;
                updatingCategory.Description = updatedCategory.Description;
                updatingCategory.Image = updatedCategory.Image;
                await _homeServiceDbContext.SaveChangesAsync(cancellationToken);
                return updatingCategory;
            }
            else
            {
                //throw an exception - will be implement!
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region PrivateMethods
        private async Task<Domain.Core.Expert.Entities.Category> GetCategory(int categoryId, CancellationToken cancellationToken)
        {
            var category = await _homeServiceDbContext.Categories
                .FirstOrDefaultAsync(a => a.Id == categoryId, cancellationToken);

            if (category != null)
            {
                return category;
            }

            throw new Exception($"admin with id {categoryId} not found");
        }
        #endregion
    }
}
