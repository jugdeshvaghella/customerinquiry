using _2C2P.CustomerInquiry.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C2P.CustomerInquiry.DAO
{
    public class CustomerInquiryContext : DbContext
    {
        public CustomerInquiryContext() : base("name=CustomerInquiryConnectionString") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transctions { get; set; }
    }
}
