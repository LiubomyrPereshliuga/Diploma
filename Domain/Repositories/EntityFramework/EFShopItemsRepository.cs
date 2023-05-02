using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFShopItemsRepository : IShopItemsRepository
    {
        private readonly AppDbContext context;
        public EFShopItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ShopItem> GetShopItems()
        {
            return context.ShopItems;
        }

        public ShopItem GetShopItemById(Guid id)
        {
            return context.ShopItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveShopItem(ShopItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteShopItem(Guid id)
        {
            context.ShopItems.Remove(new ShopItem() { Id = id });
            context.SaveChanges();
        }
    }
}
