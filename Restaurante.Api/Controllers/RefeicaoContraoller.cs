using Microsoft.AspNetCore.Mvc;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Domain.Services.Interfaces;
using Restaurante.Api.ViewModels;
using System.Threading.Tasks;

namespace Restaurante.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RefeicaoContraoller : ControllerBase
    {
        private IRefeicaoService refeicaoService;

        public RefeicaoContraoller(IRefeicaoService refeicaoService) => this.refeicaoService = refeicaoService;

        [HttpGet]
        public async Task<ActionResult> ObterRefeicoes()
        {
            var refeicoes = await refeicaoService.ObterRefeicoes();
            return Ok(refeicoes);
        }

        [HttpPost]
        public async Task<ActionResult> AdicionarRefeicao(RefeicaoViewModel refeicaoViewModel)
        {
            var refeicao = new Refeicao { Id = refeicaoViewModel.Id, NomeRefeicao = refeicaoViewModel.NomeRefeicao };

            await refeicaoService.CriarRefeicao(refeicao);
            return Created("", refeicao);
        }
    }
}
