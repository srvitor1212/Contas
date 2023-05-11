using Domain.Validation;

namespace Domain.Entities
{
    public sealed class PagamentoDeDividas : Base
    {
        public DateTime DataEfetivacao { get; private set; }

        public int DividasId { get; set; }
        public Dividas Dividas { get; set; }

        public PagamentoDeDividas(int id, DateTime dataEfetivacao)
        {
            DomainValidation.When(
                id < 0,
                "Id inválido");
            this.Id = id;

            Validation(dataEfetivacao);
        }

        public PagamentoDeDividas(DateTime dataEfetivacao)
        {
            Validation(dataEfetivacao);
        }

        public void Validation(DateTime dataEfetivacao)
        {
            this.DataEfetivacao = dataEfetivacao;
        }
    }
}
