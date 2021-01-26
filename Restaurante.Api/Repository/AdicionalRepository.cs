using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.Repository.Interfaces;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository
{
    public class AdicionalRepository : IAdicionalRepository
    {
        private readonly RestauranteContext restauranteContext;

        public AdicionalRepository(RestauranteContext restauranteContext) => this.restauranteContext = restauranteContext;

        public async Task CriarAdicional(Adicional adicional)
        {
            restauranteContext.Adicionais.Add(adicional);
            await restauranteContext.SaveChangesAsync();

        }
    }
}
