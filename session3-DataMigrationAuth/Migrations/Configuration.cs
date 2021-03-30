namespace session3_DataMigrationAuth.Migrations
{
    using session3_DataMigrationAuth.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<session3_DataMigrationAuth.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(session3_DataMigrationAuth.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(
                new Customer(){ Name="John", Age=22},
                new Customer(){ Name = "Tom", Age = 18 },
                new Customer(){ Name = "Jerry", Age = 36 },
                new Customer(){ Name = "Mary", Age = 45 }
                );

            context.SaveChanges();
        }
    }
}
