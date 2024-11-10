using System.ComponentModel.DataAnnotations;

namespace GarageService.Models
{
    public class Car{
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string License { get; set; }
        public Customer customer { get; set; }


    }
}