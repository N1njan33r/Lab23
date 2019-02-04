using Lab23.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab23.Data
{
    public class CoffeeShopDbInitializer : CreateDatabaseIfNotExists<CoffeeShopContext>
    {
        protected override void Seed(CoffeeShopContext context)
        {
            var users = new List<User>
            {
                new User{FirstName="Default_First",LastName="Default_Last",UserName="Test",Passcode="test"}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var items = new List<Item>
            {
                new Item{}
            };
            items.ForEach(s => context.Items.Add(s));
            context.SaveChanges();
        }
    }
}