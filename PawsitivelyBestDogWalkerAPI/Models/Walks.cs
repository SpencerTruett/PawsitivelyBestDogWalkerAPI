using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivelyBestDogWalkerAPI.Models
{
   public class Walks
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Date of the walk must have a date between 2 and 25 characters")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Walk duration must must be in minutes (ex. 90)")]
        public int Duration { get; set; }
        public int WalkerId { get; set; }
        public Walker Walker { get; set; }
        public int DogId { get; set; }
        public Dog Dog { get; set; }
    }
}
