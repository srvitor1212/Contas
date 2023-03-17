using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class EntradasDTO
    {
        public int Id { get; protected set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; protected set; }

        [Required(ErrorMessage = "Valor obrigatório")]
        public double Valor { get; protected set; }
    }
}
