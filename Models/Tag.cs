using System;
using System.ComponentModel.DataAnnotations;

namespace desafio01.Models
{
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Este campo deve conter até 20 caracteres")]
        public string TagName { get; set; }
    }
}