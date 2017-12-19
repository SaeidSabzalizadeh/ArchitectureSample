using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Architecture.Core.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/core
        [HttpGet("core")]
        public string GetCore()
        {
            var func = new Biz.CoreFunction();
            var value = func.Get();

            return value;
        }

        // GET api/values/standard
        [HttpGet("standard")]
        public string GetStandard()
        {
            var func = new Standard.Biz.StandardFunction();
            var value = func.Get();

            return value;
        }

        // GET api/values/framework
        [HttpGet("framework")]
        public string GetFramework()
        {
            var func = new Framework.Biz.FreameworkFunction();
            var value = func.Get();

            return value;
        }

        // GET api/values/framework/4
        [HttpGet("framework/4")]
        public string GetFramework4()
        {
            var func = new Framework4.Biz.Fr4Function();
            var value = func.Get();

            return value;
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
