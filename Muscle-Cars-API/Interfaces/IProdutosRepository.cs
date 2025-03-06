using Muscle_Cars_API.Model;

namespace Muscle_Cars_API.Interfaces
{
    public interface IProdutosRepository
    {
        Task<List<Produtos>> Get();
    }
}
