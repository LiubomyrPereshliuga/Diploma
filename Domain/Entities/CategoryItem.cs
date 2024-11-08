using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MyCompany.Domain.Entities
{
    public class CategoryItem : EntityBase
    {
        [Required(ErrorMessage = "Вкажіть назву категорії")]
        [Display(Name = "Категорія")]
        public override string Title { get; set; } = "Категорія";
        [Display(Name = "Опис категорії")]
        public string Subtitle { get; set; } = "Опис категорії";
        [Display(Name = "Зображення категорії")]
        public string TitleImage { get; set; }
        public byte[] TitleImagePath { get; set; }
    }
}
