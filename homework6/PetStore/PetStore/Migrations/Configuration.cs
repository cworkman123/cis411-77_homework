using PetStore.Models;

namespace PetStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetStore.Models.ManageDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetStore.Models.ManageDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            context.Manages.AddOrUpdate(i => i.Name,

                new Manage
                {
                    Name = "Poodle", DateReceived = DateTime.Now, Description = "Miniature Poodle that goes by the name Chewbacca or Chewy for short. He's very loving and loyal!",
                    Price = 300M, Quantity = 1
                },
                
                new Manage
                {
                    Name = "Lab", DateReceived = DateTime.Now, Description = "Full Black Lab that is very playful and hyper! He comes off as a great guard dog.",
                    Price = 100M, Quantity = 1
                },

                new Manage
                {
                    Name = "Dalmatian",
                    DateReceived = DateTime.Now,
                    Description = "This is a standard full blood Dalmatian that goes by the Name Spot. He's 2 years old, great with kids, and loves to cuddle",
                    Price = 400M,
                    Quantity = 1
                },

                new Manage
                {
                    Name = "Fenix Fox",
                    DateReceived = DateTime.Now,
                    Description = "We have a litter of Fenix Fox! They're pretty loyal pets, but can be hard to train. Suggestion: Experienced Owners Only.",
                    Price = 2000M,
                    Quantity = 3
                }

                );

        }
    }
}
