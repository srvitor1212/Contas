using Domain.Validation;

namespace Domain.Entities
{
    public sealed class Entradas : Base
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataVigencia { get; private set; }

        public Entradas(string nome, double valor, DateTime DataVigencia)
        {
            Validation(nome, valor, DataVigencia);
        }

        private void Validation(string nome, double valor, DateTime DataVigencia)
        {
            //nome
            DomainValidation.When(
                string.IsNullOrEmpty(nome),
                "Nome não pode ser em branco");

            DomainValidation.When(
                nome.Length < 3,
                "Insira um nome com pelo menos 3 letras");

            DomainValidation.When(
                nome.Length > 200,
                "Nome é muito longo");

            //valor
            DomainValidation.When(
                valor == 0,
                "Valor não pode ser zero");

            DomainValidation.When(
                valor < 0,
                "Valor não pode ser negativo");

            //dados ok
            this.Nome = nome;
            this.Valor = valor;
            this.DataVigencia = DataVigencia;

        }
    }

}
