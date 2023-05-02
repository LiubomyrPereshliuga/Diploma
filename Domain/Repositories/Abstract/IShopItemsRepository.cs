using System;
using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IShopItemsRepository
    {
        IQueryable<ShopItem> GetShopItems();
        ShopItem GetShopItemById(Guid id);
        void SaveShopItem(ShopItem entity);
        void DeleteShopItem(Guid id);
    }
}
