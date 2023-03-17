using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class RecebedoresDTO
    {
        public int Id { get; protected set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; protected set; }
    }
}
