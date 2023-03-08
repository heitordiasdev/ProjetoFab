using ProjetoFabAPI.Models.Data.Contexto;
using ProjetoFabAPI.Models.Domain.Entities;
using ProjetoFabAPI.Repositories.Interface;

namespace ProjetoFabAPI.Repositories.Repository
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(DataContexto dataContexto) : base(dataContexto)
        {
        }
    }
}
