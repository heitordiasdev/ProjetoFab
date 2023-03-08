using Microsoft.EntityFrameworkCore;

namespace ProjetoFabAPI.Data.Contexto
{
    public class DataContexto:DbContext
    {
        public DataContexto(DbContextOptions<DataContexto> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
