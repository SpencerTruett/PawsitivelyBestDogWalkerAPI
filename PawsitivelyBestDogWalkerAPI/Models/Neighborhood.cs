using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivelyBestDogWalkerAPI.Models
{
   public class Neighborhood
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Neighborhood name must be between 2 and 50 characters")]
        public string Name { get; set; }
    }
}
