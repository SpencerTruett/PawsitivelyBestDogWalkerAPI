using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivelyBestDogWalkerAPI.Models
{
   public class Dog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Dog's name must be between 2 and 50 characters")]
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Dog's breed must be between 2 and 25 characters")]
        public string Breed { get; set; }
        public string Notes { get; set; }
    }
}
