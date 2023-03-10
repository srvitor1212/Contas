namespace Contas.Domain.Entities
{
    public sealed class Dividas : Base
    {
        public string Nome { get; private set; }
        public decimal Vallor { get; private set; }
        public bool FoiPago { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public byte DiaVencimento { get; set; }

        public int PagamentosId { get; set; }
        public Pagamentos Pagamentos { get; set; }

        public Recebedores RecebedoresId { get; set; }
        public Recebedores Recebedores { get; set; }

    }
}
