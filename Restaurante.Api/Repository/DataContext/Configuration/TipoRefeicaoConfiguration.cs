using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Api.Domain.Entities;

namespace Restaurante.Api.Repository.DataContext.Configuration
{
    public class TipoRefeicaoConfiguration : IEntityTypeConfiguration<TipoRefeicao>
    {
        public void Configure(EntityTypeBuilder<TipoRefeicao> builder)
        {
            builder.ToTable("TipoRefeicao");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                   .HasColumnType("varchar(250)")
                   .IsRequired();

            builder.Property(x => x.Ativo)
                   .HasColumnType("bit")
                   .HasDefaultValue(1)
                   .IsRequired();
        }
    }
}
