using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HttpPerformanceTest.Controllers
{
    public class HelloResponse
    {
        public Customer Customer { get; set; }
    }

    public class HelloController : ApiController
    {
        // GET api/hello
        public HelloResponse Get()
        {
            return new HelloResponse()
            {
                Customer = Customer.Create()
            };
        }
    }
}