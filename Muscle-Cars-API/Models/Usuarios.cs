using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muscle_Cars_API.Model
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Key]
        public int id { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public string? senha { get; set; }

        public Usuarios(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }
    }
}
