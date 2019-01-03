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
    public class TestCustomerController
    {
        //[TestMethod]
        //public void Transactions_ShouldReturnAllTransctions()
        //{
        //    var controller = new CustomerController();

        //    var result = controller.Transactions();
        //    Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        //}

        [TestMethod]
        private void TestCustomer_ShouldReturnCustomer()
        {
            var customer = CustomerUtilities.GetCustomerByIdOrEmail(123456, "");
            Assert.AreEqual(true, customer != null);
        }
    }
}
