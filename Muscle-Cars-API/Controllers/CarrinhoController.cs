using Microsoft.AspNetCore.Mvc;

namespace Muscle_Cars_API.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
