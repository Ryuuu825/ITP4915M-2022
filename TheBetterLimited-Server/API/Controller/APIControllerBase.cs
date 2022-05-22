using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.AppLogic.Controllers;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/[controller]")]
    public class APIControllerBase<T> : ControllerBase
        where T : class
    {
        private readonly AppControllerBase<T> controller;

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
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await controller.GetById(id));
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetByQueryString(string queryString)
        {
            try
            {
                return Ok(await controller.GetByQueryString(queryString));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] T entity)
        {
            try
            {
                await controller.Add(entity);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Modify(string id, [FromBody] List<AppLogic.Models.UpdateObjectModel> content)
        {
            try
            {
                await controller.Modify(id, content);
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

        public APIControllerBase(Data.DataContext db)
        {
            controller = new AppControllerBase<T>(db);
        }
    }
}