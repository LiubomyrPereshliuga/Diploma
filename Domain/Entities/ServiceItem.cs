﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть назву товару")]
        [Display(Name = "Назва товару")]
        public override string Title { get; set; }
        [Required(ErrorMessage = "Заповність назву магазину")]
        [Display(Name = "Магазин")]
        public string ShopItem { get; set; }
        [Display(Name = "Виробник")]
        public string Maker { get; set; }
        [Required(ErrorMessage = "Заповніть категорію")]
        [Display(Name = "Категорія")]
        public string CategoryItem { get; set; }
        [Display(Name = "Зображення")]
        public string TitleImage { get; set; }
        public byte[] TitleImagePath { get; set; }
        [Display(Name = "Посилання")]
        public string URL { get; set; }
        [Required(ErrorMessage = "Заповність ціну товару")]
        [Display(Name = "Ціна")]
        public int Price { get; set; }

        [Display(Name = "Короткий опис")]
        public string Subtitle { get; set; }

        [Display(Name = "Повний опис")]
        public override string Text { get; set; }
    }
}
