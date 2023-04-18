using System.ComponentModel.DataAnnotations;

namespace WebAPI.ViewModel
{
    public class DividasViewModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }


        public decimal Valor { get; set; }


        public bool FoiPago { get; set; } = false;


        public DateTime DataInicio { get; set; }


        public DateTime DataFim { get; set; }


        public byte DiaVencimento { get; set; }


        public int PagamentosId { get; set; }


        public int RecebedoresId { get; set; }
    }
}
