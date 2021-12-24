using MediatR;

namespace DemoApp.Application.Context.Queries
{
    public class GetCurrentTimeQueryHandler : IRequestHandler<GetCurrentTimeQueryModel, DateTime>
    {
        public async Task<DateTime> Handle(GetCurrentTimeQueryModel request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(DateTime.Now);
        }
    }
}
