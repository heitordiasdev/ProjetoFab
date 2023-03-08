using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFabAPI.Models.Domain.Entities
{
    public class Equipe
    {

        [Key()]
        public int IdEquipe { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string NomeEquipe { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Setor { get; set; }

        
       
    }
}
