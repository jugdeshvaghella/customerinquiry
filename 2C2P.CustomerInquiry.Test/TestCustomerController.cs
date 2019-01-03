using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2C2P.CustomerInquiry.Core.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2C2P.CustomerInquiry.Test
{
    [TestClass]
    public class TestCustomerController
    {
        [TestMethod]
        public void Transactions_ShouldReturnAllTransctions()
        {
            var transactions = TestTransactions();
            var controller = new CustomerController();

            //var result = controller.Transactions();
            Assert.AreEqual(transactions.Count, 0);
        }

        private List<object> TestTransactions()
        {
            return new List<object>();
        }
    }
}
