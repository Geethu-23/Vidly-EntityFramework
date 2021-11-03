using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Vidly.Models
{
    public class MyDbContext : DbContext
    {

        public static MyDbContext Create()
        {
            return new MyDbContext();
        }

        public DbSet<Customer> customer { get; set; }
        public DbSet<Movie> movie { get; set; }
        public DbSet<MembershipType> membershiptype { get; set; }


    }

    
    

}
    
