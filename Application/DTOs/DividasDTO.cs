using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class DividasDTO
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(3)]
        [MaxLength(200)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Valor obrigatório")]
        public decimal Valor { get; set; }


        public bool FoiPago { get; private set; }


        public DateTime DataInicio { get; private set; }


        public DateTime DataFim { get; private set; }


        public byte DiaVencimento { get; private set; }


        public int PagamentosId { get; set; }


        public int RecebedoresId { get; set; }
    }
}
