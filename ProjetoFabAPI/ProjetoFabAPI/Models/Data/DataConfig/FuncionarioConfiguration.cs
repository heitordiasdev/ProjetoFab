using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFabAPI.Models.Domain.Entities;

namespace ProjetoFabAPI.Models.Data.DataConfig
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(k => k.IdFunc);
            builder.Property(k => k.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Cargo)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(50)");

            builder.HasOne(c => c.Equipe).WithMany(c => c.Funcionarios)
                .HasForeignKey(c => c.IdEquipe)
                .IsRequired();

        }
    }

}
