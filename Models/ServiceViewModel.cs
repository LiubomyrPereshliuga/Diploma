using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursovaProject.Models
{
    public class ServiceViewModel
    {
        public ServiceItem service { get; set; }
        public IQueryable<CategoryItem> categories { get; set; }
        public IQueryable<ShopItem> shops { get; set; }
    }
}
