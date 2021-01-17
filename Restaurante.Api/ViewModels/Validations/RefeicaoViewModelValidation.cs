using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.ViewModels.Validations
{
    public class RefeicaoViewModelValidation : AbstractValidator<RefeicaoViewModel>
    {
        public RefeicaoViewModelValidation()
        {
            RuleFor(x => x.NomeRefeicao)
                   .NotEmpty()
                   .WithMessage("Manda um nome please!");
        }
    }
}
