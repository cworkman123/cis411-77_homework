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
                    Name = "Poodle", DateReceived = DateTime.Now, Description = "The poodle is a group of formal dog breeds, the Standard Poodle, Miniature Poodle and Toy Poodle (one registry organisation also recognizes a Medium Poodle variety, between Standard and Miniature), with many coat colors. Originally bred in Germany as a type of water dog, the breed was standardized in France. The poodle is skillful in many dog sports, including agility, obedience, tracking, and even herding. Poodles have taken top honors in many conformation shows, including Best in Show at the Westminster Kennel Club Dog Show in 1991 and 2002, and at the World Dog Show in 2007 and 2010.",
                    Price = 300M, Quantity = 23
                },
                
                new Manage
                {
                    Name = "Lab", DateReceived = DateTime.Now, Description = "The Labrador Retriever, also known as simply Labrador or Lab, is one of several kinds of retrievers, a type of gun dog. Even-tempered and well-behaved around young children and the elderly. Labradors are athletic, playful, and the most popular breed of dog by registered ownership in Australia, Canada, New Zealand,[3] the United Kingdom,[4] and the United States (since 1991)",
                    Price = 100M, Quantity = 30
                },

                new Manage
                {
                    Name = "Dalmatian",
                    DateReceived = DateTime.Now,
                    Description = "The Dalmatian is a breed of dog named after the historical region of Dalmatia. The Dalmatian is noted for its unique black or liver spotted coat and was mainly used as a carriage dog in its early days. Today, this dog remains a well-loved family pet, and many dog enthusiasts enter their pets into kennel club competitions.",
                    Price = 400M,
                    Quantity = 5
                },

                new Manage
                {
                    Name = "Fennec Fox",
                    DateReceived = DateTime.Now,
                    Description = "The fennec fox or fennec (Vulpes zerda) is a small nocturnal fox found in the Sahara of North Africa. Its most distinctive feature is its unusually large ears, which serve to dissipate heat. Its name comes from the Arabic word فنك (fanak), which means fox, and the species name zerda comes from the Greek word xeros which means dry, referring to the fox's habitat.[2] The fennec is the smallest species of canid in the world. Its coat, ears, and kidney functions have adapted to high-temperature, low-water, desert environments. In addition, its hearing is sensitive enough to hear prey moving underground. It mainly eats insects, small mammals, and birds.",
                    Price = 2000M,
                    Quantity = 1
                }

                );

        }
    }
}
