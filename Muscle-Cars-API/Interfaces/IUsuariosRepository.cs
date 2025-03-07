using Muscle_Cars_API.Model;

namespace Muscle_Cars_API.Interfaces
{
    public interface IUsuariosRepository
    {
        Task<List<Usuarios>> Get();
        Task<Usuarios> Login(int id, string email, string senha);
        void Add(Usuarios usuarios);
        Task<Usuarios> BuscarPorToken(string token);
    }
}
