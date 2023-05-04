
using Domain.Entities;

namespace Application.DTOs
{
    public class PagamentoDeDividasDTO
    {
        public int Id { get; set; }

        public DateTime DataEfetivacao { get; private set; }

        public int DividasId { get; set; }
        public Dividas Dividas { get; set; }
    }
}
