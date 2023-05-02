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
        public override string Description { get; set; } = "Опис категорії";
        [Display(Name = "Зображення категорії")]
        public override string TitleImagePath { get; set; }
    }
}
