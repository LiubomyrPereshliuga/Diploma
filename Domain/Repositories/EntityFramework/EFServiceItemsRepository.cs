using System;
using System.Globalization;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;
using KursovaProject.Models;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }
        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }
        public IQueryable<ServiceItem> GetServiceItemsByTitle(string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                return context.ServiceItems.Where(p => p.Title.Contains(text));
            }
            else return context.ServiceItems;
        }
        public IQueryable<ServiceItem> GetServiceItemsByMaker(string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                return context.ServiceItems.Where(p => p.Maker.Contains(text));
            }
            else return context.ServiceItems;
        }
        public IQueryable<ServiceItem> GetServiceItemsByShop(string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                return context.ServiceItems.Where(p => p.ShopItem.Contains(text));
            }
            else return context.ServiceItems;
        }
        public IQueryable<ServiceItem> GetServiceItemsByCategory(string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                return context.ServiceItems.Where(p => p.CategoryItem.Contains(text));
            }
            else return context.ServiceItems;
        }

        public IQueryable<ServiceItem> GetServiceItemsByPrice(int num1, int num2, string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                if (num1 <= num2)
                {
                    return context.ServiceItems.Where(p => p.Price >= num1 && p.Price <= num2 && p.Title.Contains(text));
                }
                else return context.ServiceItems.Where(p => p.Title.Contains(text));
            }
            else
            {
                if (num1 < num2) { return context.ServiceItems.Where(p => p.Price >= num1 && p.Price <= num2); }
                else return context.ServiceItems.Where(p => p.Title.Contains("крісло"));
            }
        }
        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
    }
}
