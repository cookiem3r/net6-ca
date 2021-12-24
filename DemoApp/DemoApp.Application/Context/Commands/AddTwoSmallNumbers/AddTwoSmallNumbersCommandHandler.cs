using MediatR;

namespace DemoApp.Application.Context.Commands.AddTwoSmallNumbers
{
    public class AddTwoSmallNumbersCommandHandler : IRequestHandler<AddTwoSmallNumbersCommandModel, int>
    {
        public async Task<int> Handle(AddTwoSmallNumbersCommandModel request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(request.Number1+request.Number2);
        }
    }
}
