using Microsoft.AspNetCore.Mvc;
using Muscle_Cars_API.Interfaces;

namespace Muscle_Cars_API.Controllers
{
    [ApiController]
    [Route("Api/Usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosRepository _usuariosRepository;
        public UsuariosController(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        [HttpPost]
        [Route("ListUsuarios")]
        public async Task<IActionResult> ListUsuarios()
        {
            var usuarios = await _usuariosRepository.Get();
            return Ok(usuarios);
        }
    }
}
