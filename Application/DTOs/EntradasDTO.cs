using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class EntradasDTO
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Valor obrigatório")]
        public double Valor { get; set; }


        public DateTime DataVigencia { get; set; }
    }
}
