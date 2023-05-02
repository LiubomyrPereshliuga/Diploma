using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursovaProject.Models
{
    public class CategoryViewModel
    {
        public IQueryable<ServiceItem> services { get; set; }
        public CategoryItem category { get; set; }
        public IQueryable<ShopItem> shops { get; set; }
    }
}
