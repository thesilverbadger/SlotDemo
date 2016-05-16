using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SlotDemo.Api.Api
{
    public class HomeController : ApiController
    {
        public string Get()
        {
            return ConfigurationManager.AppSettings["Location"]; ;
        }
    }
}
