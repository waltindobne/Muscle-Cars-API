using Muscle_Cars_API.Model;

namespace Muscle_Cars_API.Interfaces
{
    public interface IVendidosRepository
    {
        Task<List<Vendidos>> Get();
    }
}
