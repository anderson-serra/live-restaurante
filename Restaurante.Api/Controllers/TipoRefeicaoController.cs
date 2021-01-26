using Microsoft.AspNetCore.Mvc;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.Interfaces;
using Restaurante.Api.ViewModels;
using System.Threading.Tasks;

namespace Restaurante.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoRefeicaoController : ControllerBase
    {
        private ITipoRefeicaoRepository tipoRefeicaoRepository;

        public TipoRefeicaoController(ITipoRefeicaoRepository tipoRefeicaoRepository) => this.tipoRefeicaoRepository = tipoRefeicaoRepository;

        [HttpPost]
        public async Task<ActionResult> AdicionarTipoRefeicao(TipoRefeicaoViewModel tipoRefeicaoViewModel)
        {
            var adicional = new TipoRefeicao
            {
                Nome = tipoRefeicaoViewModel.Nome,
                Ativo = true                
            };

            await tipoRefeicaoRepository.CriarTipoRefeicao(adicional);
            return Created("", tipoRefeicaoViewModel);
        }
    }
}
