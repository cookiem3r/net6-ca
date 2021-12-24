using MediatR;

namespace DemoApp.Application.Context.Queries
{
    public class GetCurrentTimeQueryModel : IRequest<DateTime>
    {
    }
}
