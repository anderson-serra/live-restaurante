using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.Repository.Interfaces;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository
{
    public class OpcaoRepository : IOpcaoRepository
    {
        private readonly RestauranteContext restauranteContext;

        public OpcaoRepository(RestauranteContext restauranteContext) => this.restauranteContext = restauranteContext;

        public async Task CriarOpcao(Opcao opcao)
        {
            restauranteContext.Opcoes.Add(opcao);
            await restauranteContext.SaveChangesAsync();
        }
    }
}
