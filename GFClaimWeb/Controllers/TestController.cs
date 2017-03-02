using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GFClaimWeb.Controllers
{
    public class TestController : ApiController
    {
        // get http://localhost:52124/api/test
        public string Get()
        {
            return "hello";
        }
    }
}
