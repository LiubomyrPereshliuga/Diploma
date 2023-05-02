using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursovaProject.Areas.Admin
{
    public class ViewModel
    {
        public IQueryable<ServiceItem> services { get; set; }
        public IQueryable<CategoryItem> categories { get; set; }
        public IQueryable<ShopItem> shops { get; set; }
    }
}
