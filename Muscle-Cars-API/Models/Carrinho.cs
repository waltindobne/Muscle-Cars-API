namespace Muscle_Cars_API.Model
{
    public class Carrinho
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idProduto { get; set; }

        public Produtos? produto { get; set; }
    }
}
