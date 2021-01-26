using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Api.Domain.Entities;

namespace Restaurante.Api.Repository.DataContext.Configuration
{
    public class PratoOpcaoConfiguration : IEntityTypeConfiguration<PratoOpcao>
    {
        public void Configure(EntityTypeBuilder<PratoOpcao> builder)
        {
            builder.ToTable("PratoOpcao");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PratoId);
            builder.Property(x => x.OpcaoId);

            builder.HasOne(x => x.Prato)
                   .WithMany(x => x.PratoOpcoes)
                   .HasForeignKey(x => x.PratoId)
                   .HasConstraintName("FK_PratoOpcao_Prato");
            
            builder.HasOne(x => x.Opcao)
                   .WithMany(x => x.PratoOpcoes)
                   .HasForeignKey(x => x.OpcaoId)
                   .HasConstraintName("FK_PratoOpcao_Opcao");
        }
    }
}
