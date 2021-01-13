using Microsoft.AspNetCore.Mvc;
namespace MvcSignal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {

        public ActionResult<dynamic> GetHello()
        {
            return Ok(new { Message = "Hello" });
        }

    }
}