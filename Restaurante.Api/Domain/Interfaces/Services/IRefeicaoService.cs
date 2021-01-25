using Restaurante.Api.Domain.Entities;
using Restaurante.Api.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurante.Api.Domain.Services.Interfaces
{
    public interface IRefeicaoService
    {
        Task CriarRefeicao(Refeicao refeicao);
        Task<IEnumerable<RefeicaoViewModel>> ObterRefeicoes();
    }
}
