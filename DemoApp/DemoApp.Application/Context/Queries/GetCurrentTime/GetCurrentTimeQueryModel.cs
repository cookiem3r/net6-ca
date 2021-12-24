using MediatR;

namespace DemoApp.Application.Context.Queries.GetCurrentTime
{
    public class GetCurrentTimeQueryModel : IRequest<DateTime>
    {
    }
}
