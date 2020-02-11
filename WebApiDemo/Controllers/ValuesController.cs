using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IProduct product;

        public ValuesController(IProduct _product)
        {
            product = _product;
        }
        // GET api/values
        public Apple Get()
        {
            product.Id = 3;
            product.Name = "DependencjectionTest";
            product.Price = 300;
            return (Apple)product;
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
