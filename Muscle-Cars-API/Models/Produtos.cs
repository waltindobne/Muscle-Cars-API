using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muscle_Cars_API.Model
{
    [Table("produtos")]
    public class Produtos
    {
        [Key]
        public int id { get; set; }
        public string? nomeprod { get; set; }
        public string? quantidade { get; set; }
        public string? valor { get; set; }
        public string? linkimg { get; set; }
    }
}
