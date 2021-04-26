using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace desafio01.Models
{
    public class Tool
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Url(ErrorMessage = "Este campo deve conter Links(URL)")]
        public string Link { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Este campo deve conter até 50 caracteres")]
        public string Title { get; set; }
        [MaxLength(1500, ErrorMessage = "Este campo deve conter 1500 caracteres")]
        public string Description { get; set; }
        public List<Tag> Tags { get; set; }
    }
}