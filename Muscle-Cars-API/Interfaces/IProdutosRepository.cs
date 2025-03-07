using Muscle_Cars_API.Model;

namespace Muscle_Cars_API.Interfaces
{
    public interface IProdutosRepository
    {
        Task<List<Produtos>> Get();
        Task<Produtos> GetId(int id);
        void Add(Produtos prod);
        Task<bool> Remove(int id);
        Task<bool> Update(int id, Produtos prodAtualizado);
    }
}
