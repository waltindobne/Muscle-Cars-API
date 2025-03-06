using Muscle_Cars_API.Model;

namespace Muscle_Cars_API.Interfaces
{
    public interface IUsuariosRepository
    {
        Task<List<Usuarios>> Get();
    }
}
