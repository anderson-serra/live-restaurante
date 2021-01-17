using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Api.Domain.Entities;
using System;

namespace Restaurante.Api.Repository.DataContext.Configuration
{
    public class RefeicaoConfiguration : IEntityTypeConfiguration<Refeicao>
    {
        public void Configure(EntityTypeBuilder<Refeicao> builder)
        {
            builder.ToTable("Refeicao");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeRefeicao)
                   .HasColumnType("varchar(250)")
                   .IsRequired();

            builder.Property(x => x.Ativo)
                   .HasColumnType("bit")
                   .HasDefaultValue(1)
                   .IsRequired();

            builder.Property(x => x.DataCadastro)
                   .HasColumnType("DateTime")
                   .HasDefaultValue(DateTime.Now)
                   .IsRequired();
        }
    }
}
