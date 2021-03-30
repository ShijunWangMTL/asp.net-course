using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session4_firstMvcApp.Models
{
    public class Calculator
    {
        [Display(Name = "Number 1")]
        [Range(1, 100)]
        public int Operand1 { get; set; }

        [Display(Name = "Number 1")]
        [Range(1, 100)]
        public int Operand2 { get; set; }

        public Operator Operator { get; set; }

        //? accept null value
        public double? Result { get; set; }
    }
}