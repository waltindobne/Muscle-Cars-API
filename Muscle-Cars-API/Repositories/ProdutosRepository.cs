using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Muscle_Cars_API.Interfaces;
using Muscle_Cars_API.Model;
using Muscle_Cars_API.Services;

namespace Muscle_Cars_API.Repositories
{
    public class ProdutosRepository : IProdutosRepository
    {
        private readonly ConnectionContext _context;

        public ProdutosRepository(ConnectionContext context)
        {
            _context = context;
        }
        public async Task<List<Produtos>> Get()
        {
            return await _context.Produtos.ToListAsync();
        }
        public async Task<Produtos> GetId(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(x => x.id == id);
        }

        public void Add(Produtos prod)
        {
            _context.Produtos.Add(prod);
            _context.SaveChanges();
        }

        public async Task<bool> Remove(int id)
        {
            var prod = await _context.Produtos.FirstOrDefaultAsync(x => x.id == id);
            _context.Produtos.Remove(prod);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(int id, Produtos prodAtualizado)
        {
            var prod = await GetId(id);

            prod.nomeprod = prodAtualizado.nomeprod;
            prod.quantidade = prodAtualizado.quantidade;
            prod.valor = prodAtualizado.valor;
            prod.linkimg = prodAtualizado.linkimg;

            _context.Produtos.Update(prod);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
