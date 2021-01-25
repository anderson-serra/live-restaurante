using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Domain.Interfaces.Services;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.Domain.Services
{
    public class AdicionalService : IAdicionalService
    {
        private readonly RestauranteContext restauranteContext;

        public AdicionalService(RestauranteContext restauranteContext) => this.restauranteContext = restauranteContext;


        public async Task CriarAdicional(Adicional adicional)
        {
            restauranteContext.Adicionais.Add(adicional);
            await restauranteContext.SaveChangesAsync();
        }
    }
}
