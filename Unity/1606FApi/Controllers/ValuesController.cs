using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1606F.IService;
using _1606F.Service;
using Unity.Attributes;

namespace _1606FApi.Controllers
{
    public class ValuesController : ApiController
    {
        [Dependency]
        public Iservice iservice { get; set; }
        // GET api/values
        public IEnumerable<string> Get()
        {
            var a1 = iservice.Add(new _1606F.Model.Student());
            var a2 = iservice.Delete(new _1606F.Model.Student());
            var a3 = iservice.Update(new _1606F.Model.Student());
            var a4 = iservice.show();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
