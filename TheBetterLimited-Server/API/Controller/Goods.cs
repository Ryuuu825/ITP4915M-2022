using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("/api/pos/goods")]
    [Authorize]
    public class POSGoods : ControllerBase
    {
        private readonly AppLogic.Controllers.GoodsController gc;
        public POSGoods(Data.DataContext db) 
        {
            gc = new AppLogic.Controllers.GoodsController(db);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int limit = 0, uint offset = 0, [FromHeader] string Language = "en")
        {
            try
            {
                if (limit == 0)
                {
                    return Ok(await gc.GetAll( User.Identity.Name , Language));
                }
                else
                {
                    return Ok(await gc.GetWithLimit(User.Identity.Name , limit , offset , Language));
                }
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id, [FromHeader] string Language = "en")
        {
            try
            {
                Hashtable entry = await gc.GetById(User.Identity.Name , id , Language);
                return Ok(entry);
            }catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(string queryString, [FromHeader] string Language = "en")
        {
            try
            {
                return Ok(await gc.GetByQueruString(User.Identity.Name , queryString , Language));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }
        public class GoodsInDto : Data.Entity.Goods // shit code
        {
            [AppLogic.Attribute.NotMapToDto]
            public string? supplierId { get; set; }
        }

        [HttpPost]
        public virtual async Task<IActionResult> Add([FromBody] GoodsInDto entity , [FromHeader] string Language = "en")
        {
            try
            {
                string id = await gc.Add(entity,Language);
                await gc.CreateSupplierGoods(id , entity.supplierId);
                return Ok();
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
                await gc.Modify(id, content,Language);
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
                gc.ModifyRange(queryString, content, Language);
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
                await gc.Delete(id);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPost("{id}/image")]
        // the image should be compressed in client side
        public async Task<IActionResult> AddImage(string id, [FromBody] byte[] image)
        {
            try
            {
                await gc.AddImage(id, image , "en");
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("{id}/image")]
        public async Task<IActionResult> GetImage(string id)
        {
            try
            {
                ConsoleLogger.Debug("GetImage");
                byte[]? image = await gc.GetImage(id);
                return File(image, "image/png");
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }
    }
}