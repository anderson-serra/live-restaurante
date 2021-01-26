using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Api.Domain.Entities;

namespace Restaurante.Api.Repository.DataContext.Configuration
{
    public class PratoConfiguration : IEntityTypeConfiguration<Prato>
    {
        public void Configure(EntityTypeBuilder<Prato> builder)
        {
            builder.ToTable("Prato");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                   .HasColumnType("varchar(250)")
                   .IsRequired();

            builder.Property(x => x.Ativo)
                   .HasColumnType("bit")
                   .HasDefaultValue(1)
                   .IsRequired();

            builder.Property(x => x.TipoPratoId)
                   .HasColumnType("integer")
                   .HasColumnName("TipoPratoId");

            builder.HasOne(x => x.TipoPrato)
                   .WithMany(x => x.Pratos)
                   .HasForeignKey(x => x.TipoPratoId)
                   .HasConstraintName("FK_TipoPrato");
        }
    }
}
