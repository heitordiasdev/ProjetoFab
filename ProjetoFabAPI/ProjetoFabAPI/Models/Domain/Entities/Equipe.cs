using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFabAPI.Models.Domain.Entities
{
    public class Equipe
    {

        public int Id { get; set; }

        public string NomeEquipe { get; set; }

        public string Setor { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }



    }

    public class EquipeSerializer
        {
        public string NomeEquipe { get; set; }

        public string Setor { get; set; }

        }
}
