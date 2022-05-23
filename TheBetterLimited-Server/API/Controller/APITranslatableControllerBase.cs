using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.AppLogic.Controllers;

namespace TheBetterLimited_Server.API.Controller
{
    public class APITranslatableControllerBase<T> : ControllerBase
        where T : class
    {
        private readonly AppTranslatableControllerBase<T> controller;

        [HttpGet]
        public async Task<IActionResult> Get(int limit)
        {
            try
            {
                if (limit == 0)
                {
                    return Ok(await controller.GetAll());
                }
                else
                {
                    return Ok(await controller.GetWithLimit(limit));
                }
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id , string Language = "en")
        {
            return Ok(await controller.GetById(id,Language));
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetByQueryString(string queryString, string Language = "en")
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
        public async Task<IActionResult> Add([FromBody] T entity , string Language = "en")
        {
            try
            {
                await controller.Add(entity,Language);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Modify(string id, [FromBody] List<AppLogic.Models.UpdateObjectModel> content , string Language = "en")
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
                await controller.ModifyRange(queryString, content , Language);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
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

        public APITranslatableControllerBase(Data.DataContext db)
        {
            controller = new AppTranslatableControllerBase<T>(db);
        }
    }
}