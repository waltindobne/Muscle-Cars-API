using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muscle_Cars_API.Model
{
    [Table("vendidos")]
    public class Vendidos
    {
        [Key]
        public int id { get; set; }
        public int idproduto { get; set; }
        public int idusuario { get; set; }
        public double valor { get; set; }
}
}
