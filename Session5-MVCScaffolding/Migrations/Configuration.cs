namespace Session5_MVCScaffolding.Migrations
{
    using Session5_MVCScaffolding.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Session5_MVCScaffolding.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Session5_MVCScaffolding.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Students.AddOrUpdate(
                new Student() { Name = "John", EnrollmentDate = DateTime.Now },
                new Student() { Name = "Tom", EnrollmentDate = DateTime.Now },
                new Student() { Name = "Jerry", EnrollmentDate = DateTime.Now },
                new Student() { Name = "Mary", EnrollmentDate = DateTime.Now }
                );
            context.SaveChanges();
        }
    }
}
