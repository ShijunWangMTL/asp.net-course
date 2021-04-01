using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session5_MVCScaffolding.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public byte[] Photo { get; set; }



    }
}