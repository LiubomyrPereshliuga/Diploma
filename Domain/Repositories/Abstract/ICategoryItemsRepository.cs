using System;
using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface ICategoryItemsRepository
    {
        IQueryable<CategoryItem> GetCategoryItems();
        CategoryItem GetCategoryItemById(Guid id);
        void SaveCategoryItem(CategoryItem entity);
        void DeleteCategoryItem(Guid id);
    }
}
