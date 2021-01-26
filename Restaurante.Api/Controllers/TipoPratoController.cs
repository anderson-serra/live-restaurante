using Microsoft.AspNetCore.Mvc;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.Interfaces;
using Restaurante.Api.ViewModels;
using System.Threading.Tasks;

namespace Restaurante.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoPratoController : ControllerBase
    {
        private ITipoPratoRepository tipoPratoRepository;

        public TipoPratoController(ITipoPratoRepository tipoPratoRepository) => this.tipoPratoRepository = tipoPratoRepository;

        [HttpPost]
        public async Task<ActionResult> AdicionarTipoPrato(TipoPratoViewModel tipoPratoViewModel)
        {
            var tipoPrato = new TipoPrato
            {
                Nome = tipoPratoViewModel.Nome,
                Ativo = true                
            };

            await tipoPratoRepository.CriarTipoPrato(tipoPrato);
            return Created("", tipoPratoViewModel);
        }
    }
}
