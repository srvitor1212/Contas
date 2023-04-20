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


        public bool FoiPago { get; set; } = false;


        public DateTime DataInicio { get; set; }


        public DateTime DataFim { get; set; }


        [Required]
        public byte DiaVencimento { get; set; }


        public int PagamentosId { get; set; }


        public int RecebedoresId { get; set; }

        public DividasDTO()
        {
            
        }

        public DividasDTO(
            string nome, 
            decimal valor, 
            bool foipago, 
            DateTime datainicio, 
            DateTime datafim, 
            byte diavencimento, 
            int pagametosid, 
            int recebedoresid)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.FoiPago = foipago;
            this.DataInicio = datainicio;
            this.DataFim = datafim;
            this.DiaVencimento = diavencimento;
            this.PagamentosId = pagametosid;
            this.RecebedoresId = recebedoresid;
        }
    }
}
