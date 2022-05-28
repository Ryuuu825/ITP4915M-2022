using Microsoft.AspNetCore.Mvc;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/sql")]
    public class CrossTablesQuery : ControllerBase
    {
        private readonly AppLogic.Controllers.MulitTableQueryController mulitTableQueryController;
        public CrossTablesQuery()
        {
            mulitTableQueryController = new AppLogic.Controllers.MulitTableQueryController();
        }

        [HttpGet]
        public async Task GetResult([FromQuery] string queryString , [FromQuery] string Tables, [FromHeader] string lang = "en")
        {
            List<string> tables = Tables.Split(',').ToList();
            await mulitTableQueryController.Get(tables , queryString , lang);
        }
    }
}