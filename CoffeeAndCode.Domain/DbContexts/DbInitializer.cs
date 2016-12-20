using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeAndCode.Domain.Entities;

namespace CoffeeAndCode.Domain.DbContexts
{
    public static class DbInitializer
    {
        public static void Initialize(CoffeeAndCodeDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{FirstName= "Danny",LastName="Brown", CreatedDateTime=DateTime.Now, LastModifiedDateTime = DateTime.Now},
                new User{FirstName= "Austin",LastName="Murphy", CreatedDateTime=DateTime.Now, LastModifiedDateTime = DateTime.Now}
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
