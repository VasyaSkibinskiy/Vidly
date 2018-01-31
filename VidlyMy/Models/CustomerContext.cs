using System.Data.Entity;

namespace VidlyMy.Models
{
    public class CustomerContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        //public DbSet<Genre> Genres { get; set; }

    }
}