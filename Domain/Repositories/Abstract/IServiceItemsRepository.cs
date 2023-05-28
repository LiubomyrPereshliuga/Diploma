using System;
using System.Linq;
using MyCompany.Domain.Entities;
using KursovaProject.Models;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        IQueryable<ServiceItem> GetServiceItemsByTitle(string text);
        IQueryable<ServiceItem> GetServiceItemsByMaker(string text);
        IQueryable<ServiceItem> GetServiceItemsByShop(string text);
        IQueryable<ServiceItem> GetServiceItemsByCategory(string text);
        IQueryable<ServiceItem> GetServiceItemsByPrice(int num1, int num2, string text);
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
