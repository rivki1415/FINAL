using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        // GET: api/Users
        public IEnumerable<string> Get()
        {
            //return UsersBLL.GetAll();
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/Users/get/5
        [Route("get/{id}")]
        public string Get1(int id)
        {
            return "value";
        }

        // GET: api/Users/get/5
        [Route("get1/{id}")]
        public string Get1(string id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]UsersDTO value)
        {
            //UsersBLL.Add()
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
