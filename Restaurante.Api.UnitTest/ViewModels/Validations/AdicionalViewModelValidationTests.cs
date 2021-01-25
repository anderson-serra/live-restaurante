using FluentAssertions;
using NUnit.Framework;
using Restaurante.Api.ViewModels;
using Restaurante.Api.ViewModels.Validations;

namespace Restaurante.Api.UnitTest.ViewModels.Validations
{
    public class AdicionalViewModelValidationTests
    {
        [Test]
        public void DeveRetornarErroQuandoNomeForVazio()
        {
            var validator = new AdicionalViewModelValidation();
            var adicionalViewModel = new AdicionalViewModel() { Nome = "" };

            var resultado = validator.Validate(adicionalViewModel);

            resultado.IsValid
                .Should()
                .BeFalse();
        }

        [Test]
        public void NaoDeveRetornarErroQuandoNomeForValidso()
        {
            var validator = new AdicionalViewModelValidation();
            var adicionalViewModel = new AdicionalViewModel() { Nome = "Nome teste" };

            var resultado = validator.Validate(adicionalViewModel);

            resultado.IsValid
                .Should()
                .BeTrue();
        }
    }
}
