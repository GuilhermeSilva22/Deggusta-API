using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeggustaAPI.Data.Entities
{
    public class BaseEntity
    {

        [Required]
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("isdeleted")]
        public bool IsDeleted { get; set; }

        [Required]
        [Column("createdate")]
        public DateTime CreatedDate { get; set; }

    }
}
