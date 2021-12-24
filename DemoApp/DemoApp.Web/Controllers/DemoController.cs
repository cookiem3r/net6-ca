using DemoApp.Application.Context.Commands.AddTwoSmallNumbers;
using DemoApp.Application.Context.Queries.GetCurrentTime;
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

        [HttpPost("api/demo/addsmallnumbers")]
        public async Task<IActionResult> AddTwoSmallNumbers(AddTwoSmallNumbersCommandModel model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
    }
}
