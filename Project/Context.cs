using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static Project.Models;

namespace Project
{
    public class Context : DbContext
    {
        public Context() : base("Store") { }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Branch> Branchs { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

    }
}