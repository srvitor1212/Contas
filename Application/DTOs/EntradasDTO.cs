using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class EntradasDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime DataVigencia { get; set; }
    }
}
