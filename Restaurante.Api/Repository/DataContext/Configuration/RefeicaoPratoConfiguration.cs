using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Api.Domain.Entities;

namespace Restaurante.Api.Repository.DataContext.Configuration
{
    public class RefeicaoPratoConfiguration : IEntityTypeConfiguration<RefeicaoPrato>
    {
        public void Configure(EntityTypeBuilder<RefeicaoPrato> builder)
        {
            builder.ToTable("RefeicaoPrato");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PratoId);
            builder.Property(x => x.RefeicaoId);
            builder.Property(x => x.Ativo)
                   .HasColumnType("bit")
                   .HasColumnName("Ativo");

            builder.HasOne(x => x.Prato)
                   .WithMany(x => x.RefeicaoPratos)
                   .HasForeignKey(x => x.PratoId)
                   .HasConstraintName("FK_RefeicaoPrato_Prato");

            builder.HasOne(x => x.Refeicao)
                   .WithMany(x => x.RefeicaoPratos)
                   .HasForeignKey(x => x.RefeicaoId)
                   .HasConstraintName("FK_RefeicaoPrato_Refeicao");
        }
    }
}
