
using System;
using System.Web.Http;
namespace FirstASPNetAPI
{
    public class DemoApiController : ApiController
    {
        public string Get()
        { 
            return "Hello from API at " + DateTime.Now.ToString();
        }

    }
}