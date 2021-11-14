using FluentValidation;
using SuperHerore.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
