using System.ComponentModel.DataAnnotations;

namespace WebAPI.ViewModel
{
    public class PagamentosViewModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(3)]
        [MaxLength(200)]
        public string Nome { get; set; }
    }
}
