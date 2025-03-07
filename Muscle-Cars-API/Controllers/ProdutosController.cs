using Microsoft.AspNetCore.Mvc;
using Muscle_Cars_API.Interfaces;

namespace Muscle_Cars_API.Controllers
{
    [ApiController]
    [Route("Api/Produtos")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosRepository _produtosRepository;
        public ProdutosController(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }

        [HttpPost]
        [Route("ListProdutos")]
        public async Task<IActionResult> ListProdutos()
        {
            var produtos = await _produtosRepository.Get();
            return Ok(produtos);
        }
    }
}
