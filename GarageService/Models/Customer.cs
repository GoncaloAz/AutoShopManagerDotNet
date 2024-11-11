using System.ComponentModel.DataAnnotations;

namespace GarageService.Models
{
    public class Customer{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public int TaxId { get; set; }
        [Required]
        public float AmmountOwed {get; set; }
    }
}