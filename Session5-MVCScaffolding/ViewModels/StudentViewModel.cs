using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session5_MVCScaffolding.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public byte[] PhotoDb { get; set; }

        public HttpPostedFileBase Photo { get; set; }

    }
}