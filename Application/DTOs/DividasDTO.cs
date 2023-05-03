using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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


        public DateTime DataInicio { get; set; }


        public DateTime DataFim { get; set; }


        [Required]
        public byte DiaVencimento { get; set; }


        [JsonIgnore]
        public int PagamentosId { get; set; }
        public PagamentosDTO Pagamentos { get; set; }


        [JsonIgnore]
        public int RecebedoresId { get; set; }
        public RecebedoresDTO Recebedores { get; set; }

        public DividasDTO()
        {

        }

        public DividasDTO(
            string nome,
            decimal valor,
            DateTime datainicio,
            DateTime datafim,
            byte diavencimento,
            int pagametosid,
            int recebedoresid)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.DataInicio = datainicio;
            this.DataFim = datafim;
            this.DiaVencimento = diavencimento;
            this.PagamentosId = pagametosid;
            this.RecebedoresId = recebedoresid;
        }

        public DividasDTO(
            int id,
            string nome,
            decimal valor,
            DateTime datainicio,
            DateTime datafim,
            byte diavencimento,
            int pagametosid,
            int recebedoresid)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
            this.DataInicio = datainicio;
            this.DataFim = datafim;
            this.DiaVencimento = diavencimento;
            this.PagamentosId = pagametosid;
            this.RecebedoresId = recebedoresid;
        }
    }
}
