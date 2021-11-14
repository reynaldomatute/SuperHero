using NUnit.Framework;
using FluentValidation.TestHelper;

namespace SuperHero.UnitTest.Commands
{
    public class Search
    {
        private SuperHerore.Application.Validations.SearchValidator validator;
        [SetUp]
        public void Setup()
        {
            validator = new SuperHerore.Application.Validations.SearchValidator();
        }

        [Test]
        public void ShouldrequiredSearchField()
        {
            validator = new SuperHerore.Application.Validations.SearchValidator();
            var command = new SuperHerore.Application.Commands.SearchCommand
            {

            };
            var result = validator.TestValidate(command);

            result.ShouldNotHaveValidationErrorFor(p => p.Search);
        }

        [Test]
        public void ShouldBeOk()
        {
            validator = new SuperHerore.Application.Validations.SearchValidator();
            var command = new SuperHerore.Application.Commands.SearchCommand
            {
                Search = "batman"
            };
            var result = validator.TestValidate(command);

            result.ShouldNotHaveValidationErrorFor(p => p.Search);
        }
    }
}
