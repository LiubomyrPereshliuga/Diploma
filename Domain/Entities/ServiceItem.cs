using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть назву товару")]
        [Display(Name = "Назва товару")]
        public override string Title { get; set; }
        [Required(ErrorMessage ="Заповність назву магазину")]
        [Display(Name = "Магазин")]
        public override string Shop { get; set; }
        [Required(ErrorMessage = "Заповність назву категорії")]
        [Display(Name = "Категорія")]
        public override string Category { get; set; }
        [Required(ErrorMessage = "Заповність ціну товару")]
        [Display(Name = "Ціна")]
        public override string Price { get; set; }

        [Display(Name = "Короткий опис")]
        public override string Subtitle { get; set; }

        [Display(Name = "Повний опис")]
        public override string Text { get; set; }
    }
}
