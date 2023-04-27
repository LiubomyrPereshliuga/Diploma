using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class CategoryItem : EntityBase
    {
        [Required(ErrorMessage = "Вкажіть назву категорії")]
        [Display(Name = "Категорія")]
        public override string Category { get; set; } = "Категорія";
        [Display(Name = "Опис категорії")]
        public override string CategoryDescription { get; set; }
    }
}
