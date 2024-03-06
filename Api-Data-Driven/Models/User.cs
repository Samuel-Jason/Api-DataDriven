using System.ComponentModel.DataAnnotations;

namespace Api_Data_Driven.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter entre 3 e 60 Caracteres.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 Caracteres.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter entre 3 e 60 Caracteres.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 Caracteres.")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
