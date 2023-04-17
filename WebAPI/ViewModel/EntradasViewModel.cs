using System.ComponentModel.DataAnnotations;

namespace WebAPI.ViewModel
{
    public class EntradasViewModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(3)]
        [MaxLength(200)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Valor obrigatório")]
        public double Valor { get; set; }


        public DateTime DataVigencia { get; set; }
    }
}
