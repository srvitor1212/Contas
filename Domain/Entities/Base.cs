namespace Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; protected set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
