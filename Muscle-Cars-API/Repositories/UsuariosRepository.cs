using Microsoft.AspNetCore.Mvc;
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
        public async Task<Usuarios> Login(int id, string email, string senha)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.email == email && x.senha == senha);
        }
        public void Add(Usuarios usuarios)
        {
            _context.Usuarios.Add(usuarios);
            _context.SaveChanges();
        }
        public async Task<Usuarios> BuscarPorToken(string token)
        {
            var email = TokenService.ReadJWT(token);
            var busca = await _context.Usuarios.FirstOrDefaultAsync(x => x.email == email);
            return busca;
        }

        public async Task<bool> Remove(int id)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.id == id);
            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
