using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Api.Domain.Entities;

namespace Restaurante.Api.Repository.DataContext.Configuration
{
    public class AdicionalConfiguration : IEntityTypeConfiguration<Adicional>
    {
        public void Configure(EntityTypeBuilder<Adicional> builder)
        {
            builder.ToTable("Adicional");
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
