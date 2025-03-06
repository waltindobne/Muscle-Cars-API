using Microsoft.AspNetCore.Mvc;

namespace Muscle_Cars_API.Controllers
{
    public class VendidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
