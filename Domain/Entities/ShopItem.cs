using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MyCompany.Domain.Entities
{
    public class ShopItem : EntityBase
    {
        [Required(ErrorMessage = "Вкажіть назву магазину")]
        [Display(Name = "Магазин")]
        public override string Title { get; set; } = "Магазин";
        [Display(Name = "Опис магазину")]
        public override string Description { get; set; }
        [Display(Name = "Зображення магазину")]
        public override string TitleImagePath { get; set; }
        [Display(Name = "Категорія магазину")]
        public string CategoryItem { get; set; }
    }
}
