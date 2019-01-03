using _2C2P.CustomerInquiry.Core.Models;
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
    public class CustomerController : ApiController
    {
        public HttpResponseMessage Transactions(int customerId = 0, string email = "")
        {
            if (customerId != 0 || !string.IsNullOrEmpty(email))
            {
                if (true)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { });
                }

                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}
