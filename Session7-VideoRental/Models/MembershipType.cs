using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session7_VideoRental.Models
{
    // Create MembershipType class
    public class MembershipType
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unkown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}