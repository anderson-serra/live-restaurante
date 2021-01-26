using Microsoft.AspNetCore.Mvc;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.Interfaces;
using Restaurante.Api.ViewModels;
using System.Threading.Tasks;

namespace Restaurante.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PratoController : ControllerBase
    {
        private IPratoRepository pratoRepository;

        public PratoController(IPratoRepository pratoRepository) => this.pratoRepository = pratoRepository;

        [HttpPost]
        public async Task<ActionResult> AdicionarPrato(PratoViewModel pratoViewModel)
        {
            var prato = new Prato
            {
                Nome = pratoViewModel.Nome,
                Ativo = true
            };

            await pratoRepository.CriarPrato(prato);
            return Created("", pratoViewModel);
        }
    }
}
