using FluentValidation;
using SuperHerore.Application.Commands;

namespace SuperHerore.Application.Validations
{
    public class SearchValidator : AbstractValidator<SearchCommand>
    {
        public SearchValidator()
        {
                RuleFor(p => p.Search)
                    .NotNull()
                    .MaximumLength(50);
        }
    }
}
