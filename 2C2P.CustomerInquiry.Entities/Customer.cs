using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C2P.CustomerInquiry.Entities
{
    [Table("customer")]
    public class Customer
    {
        public Customer()
        {
            Transactions = new HashSet<Transaction>();
        }

        [Key]
        public decimal Id { get; set; }

        [Column("name")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Column("email")]
        [MaxLength(30)]
        public string Email { get; set; }

        [Column("mobile")]
        [MaxLength(30)]
        public string Mobile { get; set; }
        
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
