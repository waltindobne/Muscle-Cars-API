using Microsoft.AspNetCore.Mvc;

namespace Muscle_Cars_API.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
