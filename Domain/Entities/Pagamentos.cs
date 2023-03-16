namespace Domain.Entities
{
    public sealed class Pagamentos : Base
    {
        public string TipoDePagamento { get; private set; }

        public ICollection<Dividas> Dividas { get; private set; }

    }
}
