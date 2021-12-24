using DemoApp.Application.Context.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DemoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/demo/currentdatetime")]
        public async Task<IActionResult> GetCurrentTimeAsync()
        {
            var result = await _mediator.Send(new GetCurrentTimeQueryModel());
            return Ok($"{result.ToLongDateString()} {result.ToLongTimeString()}");
        }
    }
}
