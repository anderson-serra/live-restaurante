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
            builder.Property(x => x.Id)
                   .UseIdentityColumn()
                   .ValueGeneratedOnAdd();

            builder.Property(x => x.NomeRefeicao)
                   .HasColumnType("varchar(250)")
                   .IsRequired();

            builder.Property(x => x.Ativo)
                   .HasColumnType("bit")
                   .HasDefaultValue(1)
                   .IsRequired();

            builder.Property(x => x.DataCadastro)
                   .HasColumnType("DateTime")
                   .HasDefaultValueSql("GETDATE()")
                   .IsRequired();

            builder.Property(x => x.TipoRefeicaoId)
                   .HasColumnType("integer")
                   .HasColumnName("TipoRefeicaoId");

            builder.HasOne(x => x.TipoRefeicao)
                   .WithMany(x => x.Refeicoes)
                   .HasForeignKey(x => x.TipoRefeicaoId)
                   .HasConstraintName("FK_TipoRefeicao");
        }
    }
}
