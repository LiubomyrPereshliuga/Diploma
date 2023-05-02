using System;
using KursovaProject.Models;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }

        public IActionResult CategoryItems()
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageCategoryItems");
            return View(dataManager.CategoryItems.GetCategoryItems());
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                ShopViewModel mymodel = new ShopViewModel();
                mymodel.services = dataManager.ServiceItems.GetServiceItems();
                mymodel.categories = dataManager.CategoryItems.GetCategoryItems();
                mymodel.shop = dataManager.ShopItems.GetShopItemById(id);
                return View("ShopShow", mymodel);
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageIndex");
            return View(dataManager.ShopItems.GetShopItems());
        }
    }
}