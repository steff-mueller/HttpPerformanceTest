using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Funq;
using ServiceStack.WebHost.Endpoints;
using ServiceStackApi.Services;

namespace ServiceStackApi.App_Start
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("ServiceStack API", typeof(HelloService).Assembly) { }

        public override void Configure(Container container)
        {
        }
    }
}