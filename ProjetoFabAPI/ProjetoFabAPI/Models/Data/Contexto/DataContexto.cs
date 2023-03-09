using Microsoft.EntityFrameworkCore;
using ProjetoFabAPI.Models.Data.DataConfig;
using ProjetoFabAPI.Models.Domain.Entities;

namespace ProjetoFabAPI.Models.Data.Contexto
{
    public class DataContexto : DbContext
    {
        public DbSet<Equipe> equipes {  get; set; }
        public DbSet<Funcionario> funcionarios { get; set; }
        public DataContexto(DbContextOptions<DataContexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Equipe>(new EquipeConfiguration().Configure);
            builder.Entity<Funcionario>(new FuncionarioConfiguration().Configure);
            base.OnModelCreating(builder);
        }

    }
}
