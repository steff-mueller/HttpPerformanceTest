using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HttpPerformanceTest.Controllers
{
    public class HelloController : ApiController
    {
        // GET api/hello
        public string Get()
        {
            return "Hello World!";
        }
    }
}