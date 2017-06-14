using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace App.DomainModels
{
    [Table("Address")]
    public class Address : BaseEntity
    {

        [StringLength(50)]
        public string Building { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Place { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        public int UserId { get; set; }

        public virtual UserDetail UserDetail { get; set; }
    }
}
