using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Manage
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateReceived { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


    }

    public class ManageDBContext : DbContext
    {
        public DbSet<Manage> Manages { get; set; }
    }
}