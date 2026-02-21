using Microsoft.AspNetCore.Mvc;

namespace Elysium_despliegue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Mensaje resolución de conflicto";
        }
    }
}
