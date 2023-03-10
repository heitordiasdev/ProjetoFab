using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFabAPI.Models.Domain.Entities
{
    public class Funcionario
    {
        public int IdFunc { get; set; }
        public string Nome { get; set; }

        public string Cargo { get; set; }

        public string Email { get; set; }

        public int IdEquipe { get; set; }
        public Equipe Equipe { get; set; }
    }
}
