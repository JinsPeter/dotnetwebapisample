using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace App.DomainModels
{
    [Table("Address")]
    public partial class Address
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Line1 { get; set; }

        [StringLength(50)]
        public string Line2 { get; set; }

        [StringLength(50)]
        public string Line3 { get; set; }

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
