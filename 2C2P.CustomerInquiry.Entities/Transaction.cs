using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C2P.CustomerInquiry.Entities
{
    [Table("transaction")]
    public class Transaction
    {
        [Key]
        public decimal Id { get; set; }

        [Column("customerid")]
        public decimal CustomerId { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }

        [Column("currencycode")]
        public string CurrencyCode { get; set; }

        [Column("status")]
        public short Status { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
