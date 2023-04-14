using System.ComponentModel.DataAnnotations;

namespace WebAPI.ViewModel
{
    public class RecebedoresViewModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
