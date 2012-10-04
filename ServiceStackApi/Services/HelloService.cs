using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace ServiceStackApi.Services
{
    [Route("/hello")]
    public class Hello : IReturn<HelloResponse> { }

    public class HelloResponse
    {
        public Customer Customer { get; set; }
    }

    public class HelloService : Service
    {
        public object Get(Hello req)
        {
            return new HelloResponse()
            {
                Customer = Customer.Create()
            };
        }
    }
}