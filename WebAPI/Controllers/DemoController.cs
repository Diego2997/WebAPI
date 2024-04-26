using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("demo")]
    public class DemoController : ControllerBase
    {
        [HttpGet("getstring")]
        public string Get()
        {
            return "diego mercado";
        }
    }
}
