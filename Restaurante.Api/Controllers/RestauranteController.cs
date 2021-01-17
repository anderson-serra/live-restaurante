using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Repository.DataContext;
using Restaurante.Api.ViewModels;
using System;
using System.Threading.Tasks;

namespace Restaurante.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestauranteController : ControllerBase
    {
        private readonly RestauranteContext restauranteContext;

        public RestauranteController(RestauranteContext restauranteContext) => this.restauranteContext = restauranteContext;

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var refeicoes = await restauranteContext.Refeicoes.ToListAsync();
            return Ok(refeicoes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var refeicao = await restauranteContext.Refeicoes.FindAsync(id);

            var refeicaoViewModel = new RefeicaoViewModel {
                Id = refeicao.Id,
                NomeRefeicao = refeicao.NomeRefeicao
            };

            return Ok(refeicaoViewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Post(RefeicaoViewModel refeicaoViewModel)
        {
            var refeicao = new Refeicao
            {
                NomeRefeicao = refeicaoViewModel.NomeRefeicao,
                Ativo = true,
                DataCadastro = DateTime.Now
                
            };

            restauranteContext.Refeicoes.Add(refeicao);
            await restauranteContext.SaveChangesAsync();

            return Created("", refeicaoViewModel);
        }
    }
}
