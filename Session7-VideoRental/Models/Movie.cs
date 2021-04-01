using Foolproof;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session7_VideoRental.Models
{
    // Create Movie class
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Added Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]

        public Genre Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Display(Name = "Number Available")]
        [LessThanOrEqualTo("NumberInStock")]
        public byte NumberAvailable { get; set; }


        
        

    }
}