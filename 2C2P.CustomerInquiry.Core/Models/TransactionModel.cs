using _2C2P.CustomerInquiry.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C2P.CustomerInquiry.Core.Models
{
    public class TransactionModel
    {
        public decimal Id { get; set; }
        public decimal CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
    }
}
