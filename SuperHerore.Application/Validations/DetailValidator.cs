using FluentValidation;
using SuperHerore.Application.Commands;

namespace SuperHerore.Application.Validations
{
    public class DetailValidator : AbstractValidator<DetailCommand>
    {
        public DetailValidator()
        {
            RuleFor(p => p.Id)
                .NotNull();
        }
    }
}
