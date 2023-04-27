using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFCategoryItemsRepository : ICategoryItemsRepository
    {
        private readonly AppDbContext context;
        public EFCategoryItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<CategoryItem> GetCategoryItems()
        {
            return context.CategoryItems;
        }

        public CategoryItem GetCategoryItemById(Guid id)
        {
            return context.CategoryItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveCategoryItem(CategoryItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteCategoryItem(Guid id)
        {
            context.CategoryItems.Remove(new CategoryItem() { Id = id });
            context.SaveChanges();
        }
    }
}
