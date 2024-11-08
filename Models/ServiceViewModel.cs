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
        public IQueryable<ServiceItem> serviceItems { get; set; }
        public SelectList CategoryItems { get; set; }
        public IEnumerable<CategoryItem> categories { get; set; }
    }
}
