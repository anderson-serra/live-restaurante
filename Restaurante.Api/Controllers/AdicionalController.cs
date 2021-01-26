using Microsoft.AspNetCore.Mvc;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.Interfaces;
using Restaurante.Api.ViewModels;
using System.Threading.Tasks;

namespace Restaurante.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdicionalController : ControllerBase
    {
        private IAdicionalRepository adicionalRepository;

        public AdicionalController(IAdicionalRepository adicionalRepository) => this.adicionalRepository = adicionalRepository;

        [HttpPost]
        public async Task<ActionResult> AdicionarAdicional(AdicionalViewModel adicionalViewModel)
        {
            var adicional = new Adicional
            {
                Id = adicionalViewModel.Id,
                Nome = adicionalViewModel.Nome
            };

            await adicionalRepository.CriarAdicional(adicional);
            return Created("", adicional);
        }
    }
}
