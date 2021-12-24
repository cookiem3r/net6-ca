using MediatR;

namespace DemoApp.Application.Context.Commands.AddTwoSmallNumbers
{
    public class AddTwoSmallNumbersCommandModel : IRequest<int>
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
    }
}
