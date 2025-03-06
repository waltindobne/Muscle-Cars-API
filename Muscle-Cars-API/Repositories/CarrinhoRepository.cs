using Microsoft.AspNetCore.Connections;
using Muscle_Cars_API.Interfaces;
using Muscle_Cars_API.Model;

namespace Muscle_Cars_API.Repositories
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly ConnectionContext _context;

        public CarrinhoRepository(ConnectionContext context)
        {
            _context = context;
        }
        public async Task<List<Carrinho>> Get()
        {
            return await _context.Carrinho.ToListAsync();
        }
    }
}
