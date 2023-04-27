using KursovaProject.Areas.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain;
using MyCompany.Models;
using System.Linq;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            ViewModel mymodel = new ViewModel();
            mymodel.services = dataManager.ServiceItems.GetServiceItems();
            mymodel.categorys = dataManager.CategoryItems.GetCategoryItems();
            return View(mymodel);
        }
    }
}