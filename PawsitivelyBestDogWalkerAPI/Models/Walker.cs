using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivelyBestDogWalkerAPI.Models
{
   public class Walker
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Dog Walker's name must be between 2 and 25 characters")]
        public string Name { get; set; }
        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public List<Walks> Walks { get; set; }

    }
}
