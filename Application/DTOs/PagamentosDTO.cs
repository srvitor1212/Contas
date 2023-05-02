using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class PagamentosDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(200)]
        public string Nome { get; set; }
    }
}
