using FluentAssertions;
using NUnit.Framework;
using Restaurante.Api.ViewModels;
using Restaurante.Api.ViewModels.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Api.UnitTest.ViewModels.Validations
{
    public class RefeicaoViewModelValidationTests
    {
        [Test]
        public void DeveRetornarErroQuandoNomeForVazio()
        {
            var validator = new RefeicaoViewModelValidation();
            var refeicaoViewModel = new RefeicaoViewModel() { NomeRefeicao = "" };

            var resultado = validator.Validate(refeicaoViewModel);

            resultado.IsValid
                .Should()
                .BeFalse();
        }

        [Test]
        public void NaoDeveRetornarErroQuandoNomeForValidso()
        {
            var validator = new RefeicaoViewModelValidation();
            var refeicaoViewModel = new RefeicaoViewModel() { NomeRefeicao = "Nome teste" };

            var resultado = validator.Validate(refeicaoViewModel);

            resultado.IsValid
                .Should()
                .BeTrue();
        }
    }
}
