﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeFirst.Model;

namespace CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyStore")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
