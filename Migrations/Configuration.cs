namespace SalesApp.Migrations
{
    using SalesApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesApp.Data.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SalesApp.Data.SalesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Region.AddOrUpdate(
                prop => prop.Id,
                new SalesRegion
                {
                    Active = true,
                    Code = "NTH",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Id = 1,
                    Name = "North Region",
                    SalesTarget = 10000.00M,
                    UpdatedBy = "Admin",
                    UpdatedDate = DateTime.Now
                },
                 new SalesRegion
                 {
                     Active = true,
                     Code = "STH",
                     CreatedBy = "Admin",
                     CreatedDate = DateTime.Now,
                     Id = 2,
                     Name = "South Region",
                     SalesTarget = 10000.00M,
                     UpdatedBy = "Admin",
                     UpdatedDate = DateTime.Now
                 }
                );

        }
    }
}
