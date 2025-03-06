using Microsoft.AspNetCore.Mvc;

namespace Muscle_Cars_API.Controllers
{
    [ApiController]
    [Route("Api/Usuarios")]
    public class ProdutosController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
