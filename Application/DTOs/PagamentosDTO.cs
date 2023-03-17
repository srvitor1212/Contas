using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class PagamentosDTO
    {
        public int Id { get; protected set; }

        [Required(ErrorMessage = "Tipo de pagamento obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string TipoDePagamento { get; protected set; }
    }
}
