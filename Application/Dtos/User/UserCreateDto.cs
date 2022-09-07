using System.ComponentModel.DataAnnotations;

namespace DeggustaAPI.Application.Dtos.User
{
    public class UserCreateDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatorio!")]
        [StringLength(30, ErrorMessage = "O nome deve conter no máximo 30 caracteres!")]
        public string Name { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "O e-mail é obrigatorio!")]
        [StringLength(30, ErrorMessage = "O e-mail deve conter no máximo 30 caracteres!")]
        public string Email { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "O telefone é obrigatorio!")]
        [StringLength(11, ErrorMessage = "O telefone deve conter no máximo 11 caracteres!")]
        public string Phone { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "O endereço é obrigatorio!")]
        [StringLength(50, ErrorMessage = "O Endereço deve conter no máximo 50 caracteres!")]
        public string Address { get; set; } = string.Empty;

    }
}
