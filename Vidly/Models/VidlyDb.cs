using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vidly.Models
{
    public class VidlyDb : DbContext
    {

        public VidlyDb() : base("Vidly") { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }

        public System.Data.Entity.DbSet<Vidly.Models.Genre> Genres { get; set; }
    }
}