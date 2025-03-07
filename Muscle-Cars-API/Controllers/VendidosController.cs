using Microsoft.AspNetCore.Mvc;
using Muscle_Cars_API.Interfaces;

namespace Muscle_Cars_API.Controllers
{
    [ApiController]
    [Route("Api/Vendidos")]
    public class VendidosController : ControllerBase
    {
        private readonly IVendidosRepository _vendidosRepository;
        public VendidosController(IVendidosRepository vendidosRepository)
        {
            _vendidosRepository = vendidosRepository;
        }

        [HttpGet]
        [Route("ListVendidos")]
        public async Task<IActionResult> ListUsuarios()
        {
            var usuarios = await _vendidosRepository.Get();
            return Ok(usuarios);
        }
    }
}
