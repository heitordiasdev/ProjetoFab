﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFabAPI.Domain.Entities;

namespace ProjetoFabAPI.Data.DataConfig
{
    public class EquipeConfiguration : IEntityTypeConfiguration<Equipe>
    {
        public void Configure(EntityTypeBuilder<Equipe> builder)
        {
            builder.ToTable("Equipe");
            builder.HasKey(k => k.NomeEquipe);
            builder.Property(k => k.NomeEquipe)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Setor)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}