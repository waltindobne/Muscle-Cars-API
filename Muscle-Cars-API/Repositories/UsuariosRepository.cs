using Microsoft.EntityFrameworkCore;
using Muscle_Cars_API.Interfaces;
using Muscle_Cars_API.Model;
using Muscle_Cars_API.Services;

namespace Muscle_Cars_API.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ConnectionContext _context;

        public UsuariosRepository(ConnectionContext context)
        {
            _context = context;
        }
        public async Task<List<Usuarios>> Get()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}
