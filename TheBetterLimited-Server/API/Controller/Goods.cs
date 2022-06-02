using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/[controller]")]
    public class Goods : APIControllerBase<Data.Entity.Goods>
    {
        private readonly AppLogic.Controllers.GoodsController gc;
        public Goods(Data.DataContext db) : base(db) 
        {
            gc = new AppLogic.Controllers.GoodsController(db);
        }

        [HttpGet]
        [Authorize]
        public override async Task<IActionResult> Get(int limit = 0, uint offset = 0, [FromHeader] string Language = "en")
        {
            try
            {
                if (limit == 0)
                {
                    return Ok(await gc.GetAll( User.Identity.Name , Language));
                }
                else
                {
                    return Ok(await gc.GetWithLimit(limit , offset , Language));
                }
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

    }
}