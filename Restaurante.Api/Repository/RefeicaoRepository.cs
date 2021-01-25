using Microsoft.EntityFrameworkCore;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository
{
    public class RefeicaoRepository : IRefeicaoRepository
    {
        private readonly RestauranteContext restauranteContext;

        public RefeicaoRepository(RestauranteContext restauranteContext) => this.restauranteContext = restauranteContext;

        public async Task CriarRefeicao(Refeicao refeicao)
        {
            restauranteContext.Refeicoes.Add(refeicao);
            await restauranteContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Refeicao>> ObterRefeicoes()
        {
            var refeicoes = await restauranteContext.Refeicoes.ToListAsync();
            return refeicoes;
        }
    }
}
