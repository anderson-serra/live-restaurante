using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Domain.Services.Interfaces;
using Restaurante.Api.Repository.Interfaces;
using Restaurante.Api.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.Domain.Services
{

    public class RefeicaoService : IRefeicaoService
    {
        private readonly IRefeicaoRepository refeicaoRepository;

        public RefeicaoService(IRefeicaoRepository refeicaoRepository) => this.refeicaoRepository = refeicaoRepository;


        public async Task CriarRefeicao(Refeicao refeicao)
        {
            await refeicaoRepository.CriarRefeicao(refeicao);
        }

        public async Task<IEnumerable<RefeicaoViewModel>> ObterRefeicoes()
        {
            var refeicoes = await refeicaoRepository.ObterRefeicoes();
            var refeicoesViewModel = refeicoes.Select(x => new RefeicaoViewModel { Id = x.Id, NomeRefeicao = x.NomeRefeicao });

            return refeicoesViewModel;
        }
    }
}
