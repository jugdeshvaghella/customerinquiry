using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C2P.CustomerInquiry.Core.Models
{
    public class CustomerModel
    {
        public CustomerModel()
        {
            Transactions = new List<TransactionModel>();
        }

        public decimal CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public List<TransactionModel> Transactions { get; set; }
    }
}
