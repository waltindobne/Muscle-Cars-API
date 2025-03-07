using Microsoft.EntityFrameworkCore;
using Muscle_Cars_API.Interfaces;
using Muscle_Cars_API.Model;
using Muscle_Cars_API.Services;

namespace Muscle_Cars_API.Repositories
{
    public class VendidosRepository : IVendidosRepository
    {
        private readonly ConnectionContext _context;

        public VendidosRepository(ConnectionContext context)
        {
            _context = context;
        }
        public async Task<List<Vendidos>> Get()
        {
            return await _context.Vendidos.ToListAsync();
        }
    }
}
