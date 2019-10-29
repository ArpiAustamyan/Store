namespace Project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
   

    internal sealed class Configuration : DbMigrationsConfiguration<Project.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Project.Context context)
        {
            //context.Products.Add(new Product { Name = "Gini", Price = 5000 });
            //context.Products.Add(new Product { Name = "Konyak", Price = 15000 });
            //context.Products.Add(new Product { Name = "Shampayn", Price = 4000 });
            //context.Products.Add(new Product { Name = "Tecilla", Price = 4000 });
            //context.Products.Add(new Product { Name = "Hyut", Price = 2000 });
            //context.Products.Add(new Product { Name = "Fresh", Price = 4000 });

            //context.Branchs.Add(new Branch { Name = "Komitas" });
            //context.Branchs.Add(new Branch { Name = "Zeytun" });
            //context.Branchs.Add(new Branch { Name = "Masiv" });
            //context.Branchs.Add(new Branch { Name = "Arabkir" });

            //context.Orders.Add(new Order { Id = 1, BranchId = 1 });
            //context.Orders.Add(new Order { Id = 2, BranchId = 1 });

            //context.OrderProducts.Add(new OrderProduct { OrderId = 1, BranchId = 1, Count = 2, ProductId = 2 });
            //context.OrderProducts.Add(new OrderProduct { OrderId = 1, BranchId = 1, Count = 5, ProductId = 6 });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
