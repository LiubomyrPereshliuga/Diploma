﻿using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using MyCompany.Service;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShopItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public ShopItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ShopItem() : dataManager.ShopItems.GetShopItemById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(ShopItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImage = titleImageFile.FileName;
                    MemoryStream ms = new MemoryStream();
                    titleImageFile.CopyTo(ms);
                    model.TitleImagePath = ms.ToArray();
                }
                else
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", "placeholder.png");
                    model.TitleImage = "Placeholder";
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            model.TitleImagePath = ms.ToArray();
                        }
                    }
                }
                dataManager.ShopItems.SaveShopItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ShopItems.DeleteShopItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}