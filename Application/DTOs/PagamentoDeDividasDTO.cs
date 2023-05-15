
using Domain.Entities;

namespace Application.DTOs
{
    public class PagamentoDeDividasDTO
    {
        public int Id { get; set; }

        public DateTime DataEfetivacao { get; set; }

        public int DividasId { get; set; }
    }
}
