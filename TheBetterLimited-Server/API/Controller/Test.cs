using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TheBetterLimited_Server.Helpers.File;
using TheBetterLimited_Server.Helpers;
using TheBetterLimited_Server.Helpers.Secure;
using TheBetterLimited_Server.AppLogic.Data;
using TheBetterLimited_Server.API.Filters;
using MailKit.Net.Smtp;
using MimeKit;
using System.Data;
using TheBetterLimited_Server.AppLogic;
using TheBetterLimited_Server.AppLogic.Models;
using TheBetterLimited_Server.AppLogic.Exceptions;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBetterLimited_Server.API.Controllers
{
    [Route("api/[controller]")]
    public class Test : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly TheBetterLimited_Server.AppLogic.Controllers.TestController _testController;

        public Test(IConfiguration config , DataContext data)
        {
            _config = config;
            _testController = new AppLogic.Controllers.TestController(data);
        }
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
            TempFile tmp = TempFileManager.Create();
            tmp.WriteAllText("SDFSDF");
            tmp.WriteAllText("sdfdf");
            str = tmp.ReadAllText();

            return Ok(str);
        }

        [HttpGet("login")]
        public IActionResult GetKey()
        {
            Account user = new Account
            {
                Password = "ASD",
                Username = "ASD"
            };
            var key = Helpers.Secure.JwtToken.Issue(user);
            return Ok(key);
        }

        [HttpGet("Auth"), Authorize(Roles = "Admin")]
        public IActionResult GetAuth()
        {
            return Ok();
        }

#if DEBUG
        [HttpGet("check/{plainText}")]
        public IActionResult Getasd(string plainText)
        {
            return Ok(Hasher.Hash(plainText));
        }
#endif

        [HttpGet("enum/entity")]
        public IEnumerable<Account> GetEntity()
        {
            return Enumerable.Range(1, 5).Select(index => new Account
            {
                Username = "ASD",
                Password = "ASD"
            }).ToArray();
        }

        [HttpGet("json/entity")]
        public IActionResult GetJsonEntity()
        {
            JArray arr = new JArray();
            arr.Add(JObject.FromObject(new Account
            {
                Username = "1",
                Password = "SDF"
            }));
            arr.Add(JObject.FromObject(new Account
            {
                Username = "2",
                Password = "akj"
            }));
            arr.Add(JObject.FromObject(new Account
            {
                Username = "3",
                Password = "akj"
            }));
            arr.Add(JObject.FromObject(new Account
            {
                Username = "4",
                Password = "akj"
            }));
            arr.Add(JObject.FromObject(new Account
            {
                Username = "5",
                Password = "akj"
            }));
            arr.Add(JObject.FromObject(new Account
            {
                Username = "6",
                Password = "akj"
            }));

            return Ok(arr);
        }


        [HttpGet]
        public ContentResult Index()
        {
            return base.Content("<h1>Hello World</h1>", "text/html");
        }


        // https://stackoverflow.com/questions/39177576/how-to-to-return-an-image-with-web-api-get-method
        [HttpGet("image")]
        public IActionResult GetIamge(string filename)
        {
            byte[] ImgFile = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + $"/img/{filename}");
            return File(ImgFile, "image/jpeg");
        }

        [HttpGet("pdf")]
        public IActionResult GetPDF(string filename)
        {
            try
            {
                byte[] pdfFile = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + $"/img/{filename}");
                return File(pdfFile, "application/pdf");

            } catch (FileNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("email")]
        public IActionResult SentEmail()
        {
            Helpers.EmailSender.SentEmail(new MailboxAddress("Ken", "210339487@stu.vtc.edu.hk"), "This is a test", MimeKit.Text.TextFormat.Html, DynamicFile.GetFile("test.html", "name=Ken;pw=asdf"));
            // return Ok(Helpers.SecretConfig.Instance.GetEmailDetail().);
            return Ok();

            
        }



        [HttpGet("Acc")]
        public IActionResult GetAccs()
        {
            return Ok(_testController.GetSth());
        }

        [HttpPost("Acc")]
        public async Task<IActionResult> CreateAccsAsync(AppLogic.Dto.Acc acc)
        {
            try
            {
                _testController.CreateSth(acc);
                return Ok();

            } catch(Exception e)
            {
                return BadRequest(e.Message);
            }

        }





        // https://stackoverflow.com/questions/43678963/send-and-receive-large-file-over-streams-in-asp-net-web-api-c-sharp



    }

}
