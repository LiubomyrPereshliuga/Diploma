using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursovaProject.Models
{
    public class ShopViewModel
    {
        public IQueryable<ServiceItem> services { get; set; }
        public IQueryable<CategoryItem> categories { get; set; }
        public ShopItem shop { get; set; }
    }
}
