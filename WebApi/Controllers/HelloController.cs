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
        public string Message { get; set; }
    }

    public class HelloController : ApiController
    {
        // GET api/hello
        public HelloResponse Get()
        {
            return new HelloResponse() { Message = "Hello World!" };
        }
    }
}