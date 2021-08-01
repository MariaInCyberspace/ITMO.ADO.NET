using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyStore")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<VipOrder> VipOrders { get; set; }


        // Fluent API
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            // Property 'LastName' of Customer Entity will be configured to have maximum length upon model creation
            dbModelBuilder.Entity<Customer>().Property(c => c.LastName).HasMaxLength(30);
        }

    }
}
