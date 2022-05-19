namespace TheBetterLimited_Server.API.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using TheBetterLimited_Server.Data;
    using TheBetterLimited_Server.AppLogic.Controllers;
    using TheBetterLimited_Server.AppLogic.Models;
    
    [Route("api/goods")]
    public class Goods : ControllerBase
    {
        // CURD: ADD, Modify, Delete, search 

        private readonly GoodsController controller;

        public Goods(DataContext db)
        {
            controller = new GoodsController(db);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllGoods()
        {
            return Ok(await controller.GetAllGoods());
        }

    //     [HttpGet("{id}")]
    //     [Authorize]
    //     public IActionResult GetGoodsById(int id)
    //     {
    //         return Ok(controller.GetGoodsById(id));
    //     }

    //     [HttpPost]
    //     [Authorize]
    //     public IActionResult AddGoods([FromBody] Data.Dto.GoodsDto goods)
    //     {
    //         try
    //         {
    //             controller.AddGoods(goods);
    //             return Ok();
    //         }
    //         catch (ICustException e)
    //         {
    //             return StatusCode(e.ReturnCode, e.GetHttpResult());
    //         }
    //     }

    //     [HttpPut("{id}")]
    //     [Authorize]
    //     public IActionResult ModifyGoods(int id, [FromBody] Data.Dto.GoodsDto goods)
    //     {
    //         try
    //         {
    //             controller.ModifyGoods(id, goods);
    //             return Ok();
    //         }
    //         catch (ICustException e)
    //         {
    //             return StatusCode(e.ReturnCode, e.GetHttpResult());
    //         }
    //     }

    //     [HttpDelete("{id}")]
    //     [Authorize]
    //     public IActionResult DeleteGoods(int id)
    //     {
    //         try
    //         {
    //             controller.DeleteGoods(id);
    //             return Ok();
    //         }
    //         catch (ICustException e)
    //         {
    //             return StatusCode(e.ReturnCode, e.GetHttpResult());
    //         }
    //     }

    //     [HttpGet("search")]
    //     [Authorize]
    //     public IActionResult SearchGoods(string queryString)
    //     {
    //         try
    //         {
    //             return Ok(controller.SearchGoods(queryString));
    //         }
    //         catch (ICustException e)
    //         {
    //             return StatusCode(e.ReturnCode, e.GetHttpResult());
    //         }
    //     }
    }
}