using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/[controller]")]
    // [Authorize]
    public class _Appointment : ControllerBase
    {
        private readonly TheBetterLimited_Server.AppLogic.Controllers.AppointmentController ac;

        public _Appointment(Data.DataContext db)
        {
            ac = new TheBetterLimited_Server.AppLogic.Controllers.AppointmentController(db);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAppointment(int day , int month)
        {
            return Ok(await ac.GetAppointment(User.Identity.Name , day, month));
        }


        [HttpPut("assign/team/{id}")]
        public async Task<IActionResult> AssignTeam(string id , [FromBody] string TeamId)
        {
            try 
            {
                ac.AssignTeam(id , TeamId);
                return Ok();
            }catch(ICustException e)
            {
                return StatusCode(e.ReturnCode , e.GetHttpResult());
            }

        }
    }
}