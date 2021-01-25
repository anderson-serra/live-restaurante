using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Api.ViewModels.Validations
{
    public class AdicionalViewModelValidation : AbstractValidator<AdicionalViewModel>
    {
        public AdicionalViewModelValidation()
        {
            RuleFor(x => x.Nome)
                   .NotEmpty()
                   .WithMessage("Manda um nome please!");
        }
    }
}
