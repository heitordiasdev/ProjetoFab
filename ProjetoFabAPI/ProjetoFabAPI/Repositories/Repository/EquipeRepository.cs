using ProjetoFabAPI.Models.Data.Contexto;
using ProjetoFabAPI.Models.Domain.Entities;
using ProjetoFabAPI.Repositories.Interface;

namespace ProjetoFabAPI.Repositories.Repository
{
    public class EquipeRepository : BaseRepository<Equipe>, IEquipeRepository
    {
        public EquipeRepository(DataContexto dataContexto) : base(dataContexto)
        {
        }
    }
}
