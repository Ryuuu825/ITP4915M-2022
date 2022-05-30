using Microsoft.AspNetCore.Mvc;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/sql")]
    public class CrossTablesQuery : ControllerBase
    {
        private readonly AppLogic.Controllers.MulitTableQueryController mulitTableQueryController;
        public CrossTablesQuery(Data.DataContext db)
        {
            mulitTableQueryController = new AppLogic.Controllers.MulitTableQueryController(db);
        }

        [HttpGet]
        public async Task<IActionResult> GetResult([FromQuery] string queryString , [FromQuery] string Tables, [FromHeader] string lang = "en")
        {
            List<string> tables = Tables.Split(',').ToList();
            try
            {
                return Ok(await mulitTableQueryController.Get(tables , queryString , lang));
            }catch(ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }
        }
    }
}