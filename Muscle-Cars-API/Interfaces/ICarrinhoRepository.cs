using Muscle_Cars_API.Model;

namespace Muscle_Cars_API.Interfaces
{
    public interface ICarrinhoRepository
    {
        Task<List<Carrinho>> Get();
        void Add(Carrinho carrinho);
    }
}
