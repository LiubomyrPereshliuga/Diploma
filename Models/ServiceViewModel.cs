using Microsoft.AspNetCore.Mvc;
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
    }
}
