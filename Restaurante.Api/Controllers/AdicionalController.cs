using Microsoft.AspNetCore.Mvc;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Domain.Interfaces.Services;
using Restaurante.Api.ViewModels;
using System.Threading.Tasks;

namespace Restaurante.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdicionalController : ControllerBase
    {
        private IAdicionalService adicionalService;

        public AdicionalController(IAdicionalService adicionalService) => this.adicionalService = adicionalService;

        [HttpPost]
        public async Task<ActionResult> AdicionarRefeicoes(AdicionalViewModel adicionalViewModel)
        {
            var adicional = new Adicional
            {
                Id = adicionalViewModel.Id,
                Nome = adicionalViewModel.Nome
            };

            await adicionalService.CriarAdicional(adicional);
            return Created("", adicional);
        }
    }
}
