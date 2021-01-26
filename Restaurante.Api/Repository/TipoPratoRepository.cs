using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository
{
    public class TipoPratoRepository : ITipoPratoRepository
    {
        private readonly RestauranteContext restauranteContext;

        public TipoPratoRepository(RestauranteContext restauranteContext) => this.restauranteContext = restauranteContext;

        public async Task CriarTipoPrato(TipoPrato tipoPrato)
        {
            restauranteContext.TipoPratos.Add(tipoPrato);
            await restauranteContext.SaveChangesAsync();
        }
    }
}
