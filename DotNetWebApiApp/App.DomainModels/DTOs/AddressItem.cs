using System.ComponentModel.DataAnnotations;
namespace App.DomainModels
{
    public class AddressItem 
    {
        public int ID { get; set; }
        [Required]
        [StringLength(200)]
        public string AddressLines { get; set; }
        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }
    }
}
