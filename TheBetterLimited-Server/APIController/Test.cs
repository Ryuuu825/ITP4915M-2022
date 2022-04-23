using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TheBetterLimited_Server.Helper.File;
using TheBetterLimited_Server.Helper;
using TheBetterLimited_Server.APIFilters;
using TheBetterLimited_Server.AppLogic.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.APIController
{
    [Route("api/[controller]")]
    public class Test : Controller
    {

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            return Ok(id);
        }

        [HttpPost("asd")]
        public IActionResult Post()
        {
            string str = @"{'Ken' : 'A'}";
            return Ok(JObject.Parse(str));
        }

        [HttpGet("tmp")]
        public IActionResult GetAsync()
        {
            String str = "";
            TempFile tmp = TempFileManager.AddTempFile();
            tmp.WriteAllText("SDFSDF");
            tmp.WriteAllText("sdfdf");
            str = tmp.ReadAllText();
           
            return Ok(str);
        }


        [HttpGet("Auth")]
        [ApiKeyAuth]
        public IActionResult GetAuth()
        {
            return Ok("I have secret key");
        }

        [HttpGet("enum/entity")]
        public IEnumerable<Accout> GetEntity()
        {
            return Enumerable.Range(1, 5).Select(index => new Accout
            {
                Username = "ASD" ,
                Password = "ASD"
            }).ToArray();
        }

        [HttpGet("json/entity")]
        public IActionResult GetJsonEntity()
        {
            JArray arr = new JArray();
            arr.Add(JObject.FromObject(new Accout
            {
                Username = "1",
                Password = SecurePasswordHasher.Hash("ASDA")
            })); ;
            arr.Add(JObject.FromObject(new Accout
            {
                Username = "2",
                Password = "akj"
            }));
            arr.Add(JObject.FromObject(new Accout
            {
                Username = "3",
                Password = "akj"
            }));
            arr.Add(JObject.FromObject(new Accout
            {
                Username = "4",
                Password = "akj"
            }));
            arr.Add(JObject.FromObject(new Accout
            {
                Username = "5",
                Password = "akj"
            }));
            arr.Add(JObject.FromObject(new Accout
            {
                Username = "6",
                Password = "akj"
            }));

            return Ok(arr);
        }

    }

}
