using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session7_VideoRental.Models
{
    // Create Genre class
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Name { get; set; }

    }
}