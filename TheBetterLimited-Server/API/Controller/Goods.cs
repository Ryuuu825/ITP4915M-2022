namespace TheBetterLimited_Server.API.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using TheBetterLimited_Server.Data;
    using TheBetterLimited_Server.AppLogic.Controllers;
    using TheBetterLimited_Server.AppLogic.Models;

    [Route("api/goods")]
    // [Authorize]
    public class Goods : APITranslatableControllerBase<Data.Entity.Goods>
    {
        // CURD: ADD, Modify, Delete, search 

        private readonly AppLogic.Controllers.GoodsController goodsController;
        public Goods(DataContext db) : base(db)
        {
            goodsController = new AppLogic.Controllers.GoodsController(db);
        }

        // return the number of photos related to the goods
        [HttpGet("photo/{id}")]
        public async Task<IActionResult> GetGoodsPhotoAmt(string id)
        {
            try
            {
                return Ok(new {result = await goodsController.GetGoodsPhotoAmt(id)});
            }catch(ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
        }

        [HttpGet("photo/{id}/{index}")]
        public async Task<IActionResult> GetGoodsPhoto(string id , int index)
        {
            try
            {
                Tuple<byte[]?,string> photo = await goodsController.GetGoodsPhoto(id , index);
                return File(photo.Item1 , $"image/{photo.Item2}");

            }catch( ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }

        }

    }
} 