using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStore.Models
{
    public class Manage
    {
        public int ID { get; set; }

        

        [Required]
        [StringLength(60, MinimumLength = 3) ]
        public string Name { get; set; }

        
        [StringLength(50000, MinimumLength = 15)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Date Received")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateReceived { get; set; }

        [Required]
        [Display(Name= "Qty")]
        [Range(1,150)]
        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


    }

    public class ManageDBContext : DbContext
    {
        public DbSet<Manage> Manages { get; set; }
    }
}