using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VidlyMy.Models
{
    public class CustomerContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Genre> Genres { get; set; }

    }
}