using Microsoft.EntityFrameworkCore;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.DataContext.Configuration;

namespace Restaurante.Api.Repository.DataContext
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext(DbContextOptions<RestauranteContext> opt)
                : base(opt)
        { }

        public DbSet<Refeicao> Refeicoes { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Adicional> Adicionais { get; set; }
        public DbSet<Opcao> Opcoes { get; set; }
        public DbSet<TipoRefeicao> TipoRefeicoes { get; set; }
        public DbSet<TipoPrato> TipoPratos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new RefeicaoConfiguration().Configure(builder.Entity<Refeicao>());
            new AdicionalConfiguration().Configure(builder.Entity<Adicional>());
            new OpcaoConfiguration().Configure(builder.Entity<Opcao>());
            new PratoConfiguration().Configure(builder.Entity<Prato>());
            new TipoPratoConfiguration().Configure(builder.Entity<TipoPrato>());
            new TipoRefeicaoConfiguration().Configure(builder.Entity<TipoRefeicao>());
        }
    }
}
