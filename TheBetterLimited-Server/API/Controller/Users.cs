using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.Data;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.API.Controller
{
    using TheBetterLimited_Server.AppLogic.Controllers;
    [Route("api/[controller]")]
    public class Users : ControllerBase
    {
        private readonly UserController controller;

        public Users(DataContext data)
        {
            controller = new UserController(data);
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task PostAsync([FromBody] Data.Entity.Account value)
        {
            await controller.CreateUserAsync(value);
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

