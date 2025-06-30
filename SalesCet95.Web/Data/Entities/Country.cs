using System.ComponentModel.DataAnnotations;

namespace SalesCet95.Web.Data.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="País")]
        [MaxLength(50, ErrorMessage ="O campo {0} dev e ter no máximo {1} caracteres!")]
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        public string? Name { get; set; }
    }
}
