using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository
{
    public class PratoRepository : IPratoRepository
    {
        private readonly RestauranteContext restauranteContext;

        public PratoRepository(RestauranteContext restauranteContext) => this.restauranteContext = restauranteContext;

        public async Task CriarPrato(Prato prato)
        {
            restauranteContext.Pratos.Add(prato);
            await restauranteContext.SaveChangesAsync();
        }
    }
}
