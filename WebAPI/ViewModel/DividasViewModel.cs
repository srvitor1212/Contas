using System.ComponentModel.DataAnnotations;

namespace WebAPI.ViewModel
{
    public class DividasViewModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }


        public decimal Valor { get; set; }


        public bool FoiPago { get; private set; }


        public DateTime DataInicio { get; private set; }


        public DateTime DataFim { get; private set; }


        public byte DiaVencimento { get; private set; }


        public int PagamentosId { get; set; }


        public int RecebedoresId { get; set; }
    }
}
