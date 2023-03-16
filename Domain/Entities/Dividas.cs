using Domain.Validation;

namespace Domain.Entities
{
    public sealed class Dividas : Base
    {
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public bool FoiPago { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public byte DiaVencimento { get; set; }

        public int PagamentosId { get; set; }
        public Pagamentos Pagamentos { get; set; }

        public int RecebedoresId { get; set; }
        public Recebedores Recebedores { get; set; }

        public Dividas(string nome, decimal valor, bool foipago,
            DateTime datainicio, DateTime datafim, byte diavencimento)
        {
            Validation(nome, valor, foipago,
                datainicio, datafim, diavencimento);
        }

        public Dividas(int id, string nome, decimal valor, bool foipago,
            DateTime datainicio, DateTime datafim, byte diavencimento)
        {
            DomainValidation.When(
                id < 0,
                "Id inválido!");

            Validation(nome, valor, foipago,
                datainicio, datafim, diavencimento);
        }

        public void Validation(string nome, decimal valor, bool foipago,
            DateTime datainicio, DateTime datafim, byte diavencimento)
        {
            //nome
            DomainValidation.When(
                string.IsNullOrEmpty(nome),
                "Nome é obrigatório");

            DomainValidation.When(
                nome.Length < 3,
                "Nome precisa ter no mínimo 2 caracteres");

            DomainValidation.When(
                nome.Length > 150,
                "Tamanho máximo de 150 caracteres");

            //valor
            DomainValidation.When(
                valor == 0,
                "Valor não pode ser zero");

            DomainValidation.When(
                valor < 0,
                "Valor não pode ser negativo");

            this.Nome = nome;
            this.Valor = valor;
            this.FoiPago = foipago;
            this.DataInicio = datainicio;
            this.DataFim = datafim;
            this.DiaVencimento = diavencimento;
        }

    }
}
