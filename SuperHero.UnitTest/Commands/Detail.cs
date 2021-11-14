using NUnit.Framework;
using FluentValidation.TestHelper;

namespace SuperHero.UnitTest.Commands
{
    public class Detail
    {
        private SuperHerore.Application.Validations.DetailValidator validator;
        [SetUp]
        public void Setup()
        {
            validator = new SuperHerore.Application.Validations.DetailValidator();
        }

        [Test]
        public void ShouldrequiredIdField()
        {
            validator = new SuperHerore.Application.Validations.DetailValidator();
            var command = new SuperHerore.Application.Commands.DetailCommand
            {

            };
            var result = validator.TestValidate(command);

            result.ShouldNotHaveValidationErrorFor(p => p.Id);
        }

        [Test]
        public void ShouldBeOk()
        {
            validator = new SuperHerore.Application.Validations.DetailValidator();
            var command = new SuperHerore.Application.Commands.DetailCommand
            {
                Id = 1
            };
            var result = validator.TestValidate(command);

            result.ShouldNotHaveValidationErrorFor(p => p.Id);
        }
    }
}
