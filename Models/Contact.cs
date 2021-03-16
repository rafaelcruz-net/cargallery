using System.ComponentModel.DataAnnotations;

namespace CarGallery.Models
{
    public class Contact
    {

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email não está em um formato correto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mensagem é obrigatório")]
        [StringLength(500, ErrorMessage = "Máximo permitido são 500 caracteres")]
        public string Message { get; set; }

    }
}