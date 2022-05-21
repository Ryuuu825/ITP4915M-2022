using System.Drawing;
using System.Drawing.Drawing2D;
using QRCoder;
    namespace TheBetterLimited_Server.API.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using TheBetterLimited_Server.Data;
    using TheBetterLimited_Server.AppLogic.Controllers;
    using TheBetterLimited_Server.AppLogic.Models;
    
    [Route("api/goods")]
    // [Authorize]
    public class Goods : ControllerBase
    {
        // CURD: ADD, Modify, Delete, search 

        private readonly GoodsController controller;

        public Goods(DataContext db)
        {
            controller = new GoodsController(db);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGoods([FromHeader] string Language)
        {
            try
            {
                return Ok(await controller.GetAllGoods(Language));
            }catch(ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGoodsById(string id)
        {
            return Ok(await controller.GetGoodsById(id));
        }

        // return the number of photos related to the goods
        [HttpGet("photo/{id}")]
        public async Task<IActionResult> GetGoodsPhotoAmt(string id)
        {
            try
            {
                return Ok(new {result = await controller.GetGoodsPhotoAmt(id)});
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
                Tuple<byte[]?,string> photo = await controller.GetGoodsPhoto(id , index);
                return File(photo.Item1 , $"image/{photo.Item2}");

            }catch( ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
        
        }
        

        [HttpPost]
        public async Task<IActionResult> AddGoods([FromHeader] string Language , [FromBody] Data.Dto.GoodsDto goods)
        {
            try
            {
                await controller.AddGoods(Language, goods);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyGoods(string id, [FromHeader] string Language , [FromBody] List<AppLogic.Models.UpdateObjectModel> content)
        {
            try
            {
                await controller.ModifyGoods(id, Language , content);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGoods(string id)
        {
            try
            {
                await controller.DeleteGoods(id);
                return Ok();
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchGoods(string queryString , [FromHeader] string Language = "en")
        {
            try
            {
                return Ok(await controller.SearchGoods(Language , queryString));
            }
            catch (ICustException e)
            {
                return StatusCode(e.ReturnCode, e.GetHttpResult());
            }
        }
    }
}