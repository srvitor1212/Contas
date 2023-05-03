using Domain.Validation;

namespace Domain.Entities
{
    public sealed class PagamentoDeDividas : Base
    {
        public DateTime DataEfetivacao { get; private set; }

        public int DividasId { get; set; }
        public Dividas Dividas { get; set; }

        public PagamentoDeDividas(int id, DateTime dataEfetivacao, int dividaId)
        {
            DomainValidation.When(
                id < 0,
                "Id inválido");
            this.Id = id;

            Validation(dataEfetivacao, dividaId);
        }

        public PagamentoDeDividas(DateTime dataEfetivacao, int dividaId)
        {
            Validation(dataEfetivacao, dividaId);
        }

        public void Validation(DateTime dataEfetivacao, int dividaId)
        {
            this.DividasId = dividaId;
            this.DataEfetivacao = dataEfetivacao;
        }
    }
}
