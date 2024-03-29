﻿using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{
    public class RecebedoresDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(3)]
        [MaxLength(200)]
        public string Nome { get; set; }
    }
}
