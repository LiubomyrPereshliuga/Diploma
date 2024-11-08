using System;
using System.IO;
using KursovaProject.Models;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DataManager dataManager;

        public CategoriesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                CategoryViewModel mymodel = new CategoryViewModel();
                mymodel.services = dataManager.ServiceItems.GetServiceItems();
                mymodel.category = dataManager.CategoryItems.GetCategoryItemById(id);
                mymodel.shops = dataManager.ShopItems.GetShopItems();
                return View("Show", mymodel);
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageCategoryItems");
            return View(dataManager.CategoryItems.GetCategoryItems());
        }
    }
}