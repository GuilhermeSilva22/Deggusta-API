using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeggustaAPI.Data.Entities
{
    public class User : BaseEntity
    {

        [Required (AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatorio!")]
        [StringLength(30, ErrorMessage = "O nome deve conter no máximo 30 caracteres!")]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "O e-mail deve conter no máximo 30 caracteres!")]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "O telefone deve conter no máximo 11 caracteres!")]
        [Column("phone")]
        public string Phone { get; set; }


        [Required]
        [StringLength(50, ErrorMessage = "O Endereço deve conter no máximo 50 caracteres!")]
        [Column("address")]
        public string Address { get; set; }

        public User() { }

        public User(string name, string email, string phone, string address)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.IsDeleted = false;
            this.CreatedDate = DateTime.Now;
        }

        public User(int id, string name, string email, string phone, string address)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Id = id;
            this.IsDeleted = false;
            this.CreatedDate = DateTime.Now;
        }
    }
}
