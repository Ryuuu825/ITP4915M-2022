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
        public async Task<IActionResult> GetAppointment(int day , int month)
        {
            return Ok(await ac.GetAppointment(User.Identity.Name , day, month));
        }
    }
}