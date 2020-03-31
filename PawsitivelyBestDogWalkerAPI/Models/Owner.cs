using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivelyBestDogWalkerAPI.Models
{
   public class Owner
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Owner name must be between 2 and 50 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(75, MinimumLength = 5, ErrorMessage = "Owner's address must be between 5 and 75 characters")]
        public string Address { get; set; }
        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Owner's phone number must be 10 digits and with dashes in the format XXX-XXX-XXXX")]
        public string Phone { get; set; }
        public List<Dog> Dogs { get; set; }
    }
}
