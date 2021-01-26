using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository
{
    public class TipoRefeicaoRepository : ITipoRefeicaoRepository
    {
        private readonly RestauranteContext restauranteContext;

        public TipoRefeicaoRepository(RestauranteContext restauranteContext) => this.restauranteContext = restauranteContext;

        public async Task CriarTipoRefeicao(TipoRefeicao tipoRefeicao)
        {
            restauranteContext.TipoRefeicoes.Add(tipoRefeicao);
            await restauranteContext.SaveChangesAsync();
        }
    }
}
