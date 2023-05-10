using System;
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
        [Required(ErrorMessage = "Заповніть категорію")]
        [Display(Name = "Категорія")]
        public string CategoryItem { get; set; }
        [Display(Name = "Зображення")]
        public override string TitleImagePath { get; set; }
        [Required(ErrorMessage = "Заповність ціну товару")]
        [Display(Name = "Ціна")]
        public string Price { get; set; }

        [Display(Name = "Короткий опис")]
        public override string Subtitle { get; set; }

        [Display(Name = "Повний опис")]
        public override string Text { get; set; }
    }
}
