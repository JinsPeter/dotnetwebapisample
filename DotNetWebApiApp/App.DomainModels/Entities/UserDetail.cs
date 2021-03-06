using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.DomainModels
{
    [Table("UserDetail")]
    public class UserDetail : BaseEntity
    {
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public long? Phone { get; set; }

        public virtual Address Address { get; set; }
    }
}
