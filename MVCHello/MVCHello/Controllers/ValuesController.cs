﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCHello.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        static List<string> data = initList();
        private static List<string> initList()
        { 
            var ret = new List<string>();
            ret.Add("value1");
            ret.Add("value2");
            return ret;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return data;
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    //return "value";
        //    return data[id];
        //}
        public HttpResponseMessage Get(int id)
        { 
            if(data.Count > id)
            {
                return Request.CreateResponse<string>(HttpStatusCode.OK, data[id]);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Item not found");
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            data.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            data[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            data.RemoveAt(id);
        }
    }
}
