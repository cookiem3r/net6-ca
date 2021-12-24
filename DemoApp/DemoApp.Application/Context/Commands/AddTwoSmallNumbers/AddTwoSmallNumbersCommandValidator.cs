using FluentValidation;

namespace DemoApp.Application.Context.Commands.AddTwoSmallNumbers
{
    public class AddTwoSmallNumbersCommandValidator : AbstractValidator<AddTwoSmallNumbersCommandModel>
    {
        public AddTwoSmallNumbersCommandValidator()
        {
            RuleFor(_ => _.Number1)
                .LessThanOrEqualTo(9)
                .GreaterThanOrEqualTo(0);

            RuleFor(_ => _.Number2)
                .LessThanOrEqualTo(9)
                .GreaterThanOrEqualTo(0); 

        }
    }
}
