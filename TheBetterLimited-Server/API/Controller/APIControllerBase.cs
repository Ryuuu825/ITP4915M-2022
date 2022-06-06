using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.AppLogic.Controllers;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/[controller]")]
    public class APIControllerBase<T> : ControllerBase
        where T : class
    {
        private readonly AppControllerBase<T> controller;

        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            try
            {
                return Ok(await controller.Index());
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get(int limit = 0, uint offset = 0, [FromHeader] string Language = "en")
        {
            try
            {
                if (limit == 0)
                {
                    return Ok(await controller.GetAll(Language));
                }
                else
                {
                    return Ok(await controller.GetWithLimit(limit , offset , Language));
                }
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }


        [HttpGet("csv")]
        public async Task<IActionResult> GetCSV(string queryStr)
        {
            try
            {
                return Ok(await controller.GetCSV(queryStr));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("pdf")]
        public async Task<IActionResult> GetPDF(string queryStr)
        {
            try
            {
                return File(await controller.GetPDF(queryStr) , "application/pdf");
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(string id , [FromHeader] string Language = "en")
        {
            return Ok(await controller.GetById(id,Language));
        }

        [HttpGet("search")]
        public virtual async Task<IActionResult> GetByQueryString(string queryString, [FromHeader] string Language = "en")
        {
            try
            {
                return Ok(await controller.GetByQueryString(queryString,Language));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> Add([FromBody] T entity , [FromHeader] string Language = "en")
        {
            try
            {
                await controller.Add(entity,Language);
                return Ok(entity.GetType().GetProperties().Where(p => p.Name.ToLower() == "id").First().GetValue(entity));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Modify(string id, [FromBody] List<AppLogic.Models.UpdateObjectModel> content , [FromHeader] string Language = "en")
        {
            try
            {
                await controller.Modify(id, content,Language);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }
        [HttpPut]
        public async Task<IActionResult> ModifyRange(string queryString , [FromHeader] string Language , [FromBody] List<AppLogic.Models.UpdateObjectModel> content)
        {
            try
            {
                controller.ModifyRange(queryString, content, Language);
                return Ok();
            }
            catch (BadArgException e)
            {
                ConsoleLogger.Debug("DF");
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
            catch (Exception e)
            {
                ConsoleLogger.Debug(e.Message);
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(string id)
        {
            try
            {
                await controller.Delete(id);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        public APIControllerBase(Data.DataContext db)
        {
            controller = new AppControllerBase<T>(db);
        }
    }
}