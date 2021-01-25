using Restaurante.Api.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurante.Api.Repository.Interfaces
{
    public interface IRefeicaoRepository
    {
        Task CriarRefeicao(Refeicao refeicao);
        Task<IEnumerable<Refeicao>> ObterRefeicoes();
    }
}
