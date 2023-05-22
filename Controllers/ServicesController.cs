using System;
using KursovaProject.Models;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
        public IActionResult Find(string text, string radio, int num1, int num2, string checkbox)
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            switch (radio)
            {
                case "1":
                    if (checkbox == "5")
                    {
                        return View(dataManager.ServiceItems.GetServiceItemsByPrice(num1, num2, text));
                    }
                    else return View(dataManager.ServiceItems.GetServiceItemsByTitle(text));
                case "2":
                    return View(dataManager.ServiceItems.GetServiceItemsByMaker(text));
                case "3":
                    return View(dataManager.ServiceItems.GetServiceItemsByShop(text));
                case "4": 
                    return View(dataManager.ServiceItems.GetServiceItemsByCategory(text));
                default:
                    return View(dataManager.ServiceItems.GetServiceItems());
            }
        }
    }
}