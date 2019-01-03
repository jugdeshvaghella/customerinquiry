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
        public HttpResponseMessage Transactions()
        {
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}
