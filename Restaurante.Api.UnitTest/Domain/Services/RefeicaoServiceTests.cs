using FluentAssertions;
using Moq;
using NUnit.Framework;
using Restaurante.Api.Domain.Entities;
using Restaurante.Api.Domain.Services;
using Restaurante.Api.Domain.Services.Interfaces;
using Restaurante.Api.Repository.Interfaces;
using Restaurante.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restaurante.Api.UnitTest.Domain.Services
{
    public class RefeicaoServiceTests
    {
        private IRefeicaoService refeicaoService;
        private Mock<IRefeicaoRepository> refeicaoRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            refeicaoRepositoryMock = new Mock<IRefeicaoRepository>();
            refeicaoService = new RefeicaoService(refeicaoRepositoryMock.Object);
        }

        [Test]
        public async Task ObterRefeicoes_DeveRetornarUmaListaDeRefeicoes()
        {
            var refeicoesMock = new List<Refeicao> { new Refeicao { Id = 1, Ativo = true, NomeRefeicao = "Refeicao Teste", DataCadastro = DateTime.Now } };
            refeicaoRepositoryMock.Setup(x => x.ObterRefeicoes())
                                  .ReturnsAsync(refeicoesMock);

            var refeicoesEsperadas = new List<RefeicaoViewModel>() { new RefeicaoViewModel { Id = refeicoesMock[0].Id, NomeRefeicao = refeicoesMock[0].NomeRefeicao } };

            var refeicoes = await refeicaoService.ObterRefeicoes();

            refeicoes.Should()
                     .BeEquivalentTo(refeicoesEsperadas, opt => opt.IgnoringCyclicReferences());

            refeicaoRepositoryMock.Verify(x => x.ObterRefeicoes(), Times.Once);
        }

    }
}
