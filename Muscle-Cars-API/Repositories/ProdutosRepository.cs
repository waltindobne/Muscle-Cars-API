using Microsoft.AspNetCore.Connections;
using Muscle_Cars_API.Interfaces;
using Muscle_Cars_API.Model;

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
    }
}
