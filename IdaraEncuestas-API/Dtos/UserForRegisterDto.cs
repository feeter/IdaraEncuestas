using System.ComponentModel.DataAnnotations;

namespace IdaraEncuestas_API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required(ErrorMessage="Password es obligatorio")]
        [StringLength(8, MinimumLength = 8, ErrorMessage="Debe especificar una clave de 4 a 8 caracteres")]
        public string Password { get; set; }
    }
}