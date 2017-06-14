using System.ComponentModel.DataAnnotations;
namespace App.DomainModels
{
    public class UserDetailItem
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public long? Phone { get; set; }

        public AddressItem Address { get; set; }

    }
}
