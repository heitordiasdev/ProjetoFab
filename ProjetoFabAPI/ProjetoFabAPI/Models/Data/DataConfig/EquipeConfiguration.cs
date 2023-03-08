﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFabAPI.Models.Domain.Entities;

namespace ProjetoFabAPI.Models.Data.DataConfig
{
    public class EquipeConfiguration : IEntityTypeConfiguration<Equipe>
    {
        public void Configure(EntityTypeBuilder<Equipe> builder)
        {
            builder.ToTable("Equipe");

            builder.HasKey(k => k.IdEquipe);
            builder.Property(k => k.IdEquipe)
                .IsRequired();

            builder.Property(k => k.NomeEquipe)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Setor)
                .HasColumnType("varchar(50)")
                .IsRequired();

            
        }
    }
}
