using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Назва сторінки (заголовок)")]
        public override string Title { get; set; } = "Інформаційна сторінка";

        [Display(Name = "Що є на сторінці")]
        public override string Text { get; set; } = "Все заповнюється адміном";
    }
}
