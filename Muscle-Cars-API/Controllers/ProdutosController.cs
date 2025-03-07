using Microsoft.AspNetCore.Mvc;
using Muscle_Cars_API.Interfaces;
using Muscle_Cars_API.Model;

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

        [HttpGet]
        [Route("ListProdutos")]
        public async Task<IActionResult> ListProdutos()
        {
            var produtos = await _produtosRepository.Get();
            return Ok(produtos);
        }

        [HttpGet]
        [Route("ListProdId")]
        public async Task<IActionResult> GetProdId(int id)
        {
            var produto = await _produtosRepository.GetId(id);
            return Ok(produto);
        }

        [HttpPost]
        [Route("Adicionar")]
        public IActionResult NewProduto(Produtos prod)
        {
            _produtosRepository.Add(prod);
            return Ok(prod);
        }

        [HttpPut]
        [Route("Update/{id}")]
        public async Task<IActionResult> EditProd(int id, [FromBody] Produtos prod)
        {
            bool atualizado = await _produtosRepository.Update(id, prod);

            if (!atualizado)
            {
                return NotFound(new { mensage = "Produto não encontrado" });
            }

            return Ok(new { mensage = "Produto Atualizado com sucesso" });
        }

        [HttpDelete]
        [Route("Remover/{id}")]
        public async Task<IActionResult> DelProd(int id)
        {
            bool removido = await _produtosRepository.Remove(id);

            if (!removido)
            {
                return NotFound(new { message = "Produto não encontrado." });
            }

            return Ok(new { message = "Produto removido com sucesso." });
        }
    }
}
