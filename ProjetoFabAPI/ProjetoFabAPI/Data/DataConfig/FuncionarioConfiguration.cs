using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFabAPI.Domain.Entities;

namespace ProjetoFabAPI.Data.DataConfig
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(k => k.Nome);
            builder.Property(k => k.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Cargo)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(50)");

                
        }
    }
    
    }
