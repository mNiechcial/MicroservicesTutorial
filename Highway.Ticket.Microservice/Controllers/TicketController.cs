using Highway.Ticket.Microservice.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Highway.Ticket.Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpPost]
        public async Task<IActionResult> RegisterEntrance(RegisterTicketCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
