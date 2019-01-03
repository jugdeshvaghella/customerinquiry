using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using _2C2P.CustomerInquiry.Core.Controllers;
using _2C2P.CustomerInquiry.Core.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2C2P.CustomerInquiry.Test
{
    [TestClass]
    public class TestCustomerUtilities
    {
        [TestMethod]
        private void TestCustomerId_ShouldReturnCustomer()
        {
            var customer = CustomerUtilities.GetCustomerByIdOrEmail(435622);
            Assert.AreEqual(true, customer != null);
        }

        [TestMethod]
        private void TestCustomerEmail_ShouldReturnCustomer()
        {
            var customer = CustomerUtilities.GetCustomerByIdOrEmail(email: "m.martinez16@example.com");
            Assert.AreEqual(true, customer != null);
        }

        [TestMethod]
        private void TestCustomerTransactions_ShouldReturnCustomer()
        {
            var customer = CustomerUtilities.GetCustomerByIdOrEmail(email: "m.martinez16@example.com");
            Assert.AreEqual(true, customer.Transactions.Count() > 0);
        }
    }
}
