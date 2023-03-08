using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFabAPI.Domain.Entities
{
    public class Funcionario
    {
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Cargo { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Referencia { get; set; }

        [ForeignKey("Equipe")]
        public string NomeEquipe { get; set; }
        public virtual Equipe Equipe { get; set; } 
    }
}
