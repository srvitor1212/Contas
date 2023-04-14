using Domain.Validation;

namespace Domain.Entities
{
    public sealed class Recebedores : Base
    {
        public string Nome { get; private set; }

        public ICollection<Dividas> Dividas { get; private set; }

        public Recebedores(string nome)
        {
            Validation(nome);
        }

        public void Update(string nome)
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
                "Nome deve conter ao menos 3 caracteres");

            DomainValidation.When(
                nome.Length > 200,
                "Nome é muito longo");

            this.Nome = nome;
        }
    }
}
