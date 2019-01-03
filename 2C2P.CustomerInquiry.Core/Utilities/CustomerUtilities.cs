using _2C2P.CustomerInquiry.Core.Enums;
using _2C2P.CustomerInquiry.Core.Models;
using _2C2P.CustomerInquiry.DAO;
using _2C2P.CustomerInquiry.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C2P.CustomerInquiry.Core.Utilities
{
    public class CustomerUtilities
    {
        public static Customer GetCustomerByIdOrEmail(decimal customerId = 0, string email = "")
        {
            var customer = default(Customer);
            using (var context = new CustomerInquiryContext())
            {
                if (customerId > 0)
                {
                    customer = context.Customers.Include("Transactions").FirstOrDefault(c => c.Id == customerId);
                }
                else if (!string.IsNullOrEmpty(email))
                {
                    customer = context.Customers.Include("Transactions").FirstOrDefault(c => c.Email.ToLower() == email.ToLower());
                }
            }
            return customer;
        }

        public static CustomerModel Model(Customer customer)
        {
            var model = new CustomerModel
            {
                CustomerId = customer.Id,
                Email = customer.Email,
                Name = customer.Name,
                Mobile = customer.Mobile,
                Transactions = customer.Transactions.Select(t => new TransactionModel()
                {
                    Id = t.Id,
                    CustomerId = t.CustomerId,
                    Amount = t.Amount,
                    Date = t.Date,
                    Currency = t.CurrencyCode,
                    Status = ((TransactionStatus)t.Status).ToString()
                }).ToList()
            };
            return model;
        }
    }
}
