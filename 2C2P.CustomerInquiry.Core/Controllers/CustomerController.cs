using _2C2P.CustomerInquiry.Core.Models;
using _2C2P.CustomerInquiry.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace _2C2P.CustomerInquiry.Core.Controllers
{
    //[RoutePrefix("api")]
    public class CustomerController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Transactions(int customerId = 0, string email = "")
        {
            if (customerId != 0 || !string.IsNullOrEmpty(email))
            {
                var customer = CustomerUtilities.GetCustomerByIdOrEmail(customerId, email);
                if (customer != null)
                {
                    var model = CustomerUtilities.Model(customer);
                    return Request.CreateResponse(HttpStatusCode.OK, model);
                }

                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
