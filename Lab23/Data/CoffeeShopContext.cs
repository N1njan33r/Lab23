using System;
using System.Collections.Generic;
using Lab23.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Lab23.Data
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext() : base("CoffeeShopContext")
        {
            Database.SetInitializer(new CoffeeShopDbInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}