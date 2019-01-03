using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C2P.CustomerInquiry.Core.Models
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
    }
}
