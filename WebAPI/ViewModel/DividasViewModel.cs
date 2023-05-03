namespace WebAPI.ViewModel
{
    public class DividasViewModel
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public byte DiaVencimento { get; set; }
        public int PagamentosId { get; set; }
        public int RecebedoresId { get; set; }
    }
}
