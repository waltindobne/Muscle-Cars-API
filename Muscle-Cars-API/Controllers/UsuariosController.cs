using Microsoft.AspNetCore.Mvc;
using Muscle_Cars_API.Interfaces;
using Muscle_Cars_API.Model;
using Muscle_Cars_API.Services;

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

        [HttpGet]
        [Route("ListUsuarios")]
        public async Task<IActionResult> ListUsuarios()
        {
            var usuarios = await _usuariosRepository.Get();
            return Ok(usuarios);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> ListUsery([FromBody] Usuarios login)
        {
            var user = await _usuariosRepository.Login(login.id, login.email, login.senha);
            if (user != null)
            {
                var token = TokenService.GenerateToken(user);
                return Ok(token);
            }
            return Unauthorized("Email e/ou senha incorretos");
        }

        [HttpPost]
        [Route("Adicionar")]
        public IActionResult NewUser(Usuarios usuario)
        {
            _usuariosRepository.Add(usuario);
            return Ok(usuario);
        }

        [HttpGet]
        [Route("BuscarPorTokenJWT/{token}")]
        public async Task<IActionResult> BuscarPorTokenJWT(string token)
        {
            var Perfil = await _usuariosRepository.BuscarPorToken(token);

            if (Perfil == null)
            {
                return NotFound($"Perfil não encontrado");
            }

            return Ok(Perfil);
        }
    }
}
