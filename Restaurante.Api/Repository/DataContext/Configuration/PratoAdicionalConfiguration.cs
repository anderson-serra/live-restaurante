using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Api.Domain.Entities;

namespace Restaurante.Api.Repository.DataContext.Configuration
{
    public class PratoAdicionalConfiguration : IEntityTypeConfiguration<PratoAdicional>
    {
        public void Configure(EntityTypeBuilder<PratoAdicional> builder)
        {
            builder.ToTable("PratoAdicional");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PratoId);
            builder.Property(x => x.AdicionalId);

            builder.HasOne(x => x.Prato)
                   .WithMany(x => x.PratoAdicionais)
                   .HasForeignKey(x => x.PratoId)
                   .HasConstraintName("FK_PratoAdicional_Prato");

            builder.HasOne(x => x.Adicional)
                   .WithMany(x => x.PratoAdicionais)
                   .HasForeignKey(x => x.AdicionalId)
                   .HasConstraintName("FK_PratoAdicional_Adicional");
        }
    }
}
