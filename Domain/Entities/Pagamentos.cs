using Domain.Validation;

namespace Domain.Entities
{
    public sealed class Pagamentos : Base
    {
        public string Nome { get; private set; }

        public ICollection<Dividas> Dividas { get; private set; }

        public Pagamentos(string nome)
        {
            Validation(nome);
        }

        private void Validation(string nome)
        {
            DomainValidation.When(
                string.IsNullOrEmpty(nome),
                "Nome não pode ser em branco");

            DomainValidation.When(
                nome.Length < 3,
                "Insira um nome com pelo menos 3 letras");

            DomainValidation.When(
                nome.Length > 200,
                "Nome é muito longo");

            this.Nome = nome;
        }

    }
}
