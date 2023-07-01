using Highway.Gate.Microservice.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Highway.Gate.Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GateController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpPost("entry")]
        public async Task<IActionResult> RegisterEntrance(RegisterEntranceCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPost("exit")]
        public async Task<IActionResult> RegisterExit(RegisterExitCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
