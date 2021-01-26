using Microsoft.AspNetCore.Mvc;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.Interfaces;
using Restaurante.Api.ViewModels;
using System.Threading.Tasks;

namespace Restaurante.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpcaoController : ControllerBase
    {
        private IOpcaoRepository opcaoRepository;

        public OpcaoController(IOpcaoRepository opcaoRepository) => this.opcaoRepository = opcaoRepository;

        [HttpPost]
        public async Task<ActionResult> AdicionarOpcao(OpcaoViewModel opcaoViewModel)
        {
            var opcao = new Opcao
            {
                Nome = opcaoViewModel.Nome,
                Ativo = true                
            };

            await opcaoRepository.CriarOpcao(opcao);
            return Created("", opcaoViewModel);
        }
    }
}
