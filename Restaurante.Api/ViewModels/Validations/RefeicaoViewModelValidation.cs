using FluentValidation;

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
