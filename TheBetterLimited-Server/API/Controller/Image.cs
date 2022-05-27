using Microsoft.AspNetCore.Mvc;

namespace TheBetterLimited_Server.API.Controller
{
    [Route("api/[controller]")]
    public class Image : ControllerBase
    {
        // receive an image from client
        [HttpPost("1")]
        public IActionResult Post([FromBody] string image)
        {
            
            return File(Convert.FromBase64String(image), "image/jpeg");
        }

        [HttpPost("2")]
        public async Task<IActionResult> Post([FromBody] byte[] image)
        {
            try
            {
                string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "/var/tmp/", "image.jpg");
                using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write,
                    FileShare.None, 4096, useAsync: true))
                {
                    // Read the file from the request body.
                    await Request.Body.CopyToAsync(fs);
                }

                // return the image received
                return File(image, "image/jpeg");
            }
            catch (Exception ex)
            {
                return BadRequest("ERROR: Audio could not be saved on server.");
            }

        }
    }

         
}