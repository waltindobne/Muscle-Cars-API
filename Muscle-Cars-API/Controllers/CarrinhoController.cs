using Microsoft.AspNetCore.Mvc;
using Muscle_Cars_API.Interfaces;
using Muscle_Cars_API.Model;
using Muscle_Cars_API.Repositories;

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

        [HttpGet]
        [Route("ListCarrinho")]
        public async Task<IActionResult> ListCarrinho()
        {
            var carrinho = await _carrinhoRepository.Get();
            return Ok(carrinho);
        }

        [HttpPost]
        [Route("Adicionar")]
        public IActionResult NewUser(Carrinho carrinho)
        {
            _carrinhoRepository.Add(carrinho);
            return Ok(carrinho);
        }
    }
}
