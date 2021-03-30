using Session5_MVCScaffoldingWithoutAuth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Session5_MVCScaffoldingWithoutAuth.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
    }
}