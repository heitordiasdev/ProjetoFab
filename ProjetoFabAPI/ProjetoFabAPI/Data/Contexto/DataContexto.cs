using Microsoft.EntityFrameworkCore;
using ProjetoFabAPI.Data.DataConfig;
using ProjetoFabAPI.Domain.Entities;

namespace ProjetoFabAPI.Data.Contexto
{
    public class DataContexto:DbContext
    {
        public DataContexto(DbContextOptions<DataContexto> options):base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Equipe>(new EquipeConfiguration().Configure);
            builder.Entity<Funcionario>(new FuncionarioConfiguration().Configure);
            base.OnModelCreating(builder);
        }

    }
}
