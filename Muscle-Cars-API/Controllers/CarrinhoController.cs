using Microsoft.AspNetCore.Mvc;
using Muscle_Cars_API.Interfaces;

namespace Muscle_Cars_API.Controllers
{
    [ApiController]
    [Route("Api/Carrinho")]
    public class CarrinhoController : ControllerBase
    {
        private readonly ICarrinhoRepository _carrinhoRepository;
        public CarrinhoController(ICarrinhoRepository carrinhoRepository)
        {
            _carrinhoRepository = carrinhoRepository;
        }

        [HttpPost]
        [Route("ListCarrinho")]
        public async Task<IActionResult> ListCarrinho()
        {
            var carrinho = await _carrinhoRepository.Get();
            return Ok(carrinho);
        }
    }
}
