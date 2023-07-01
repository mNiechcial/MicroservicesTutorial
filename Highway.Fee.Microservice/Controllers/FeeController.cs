using Highway.Fee.Microservice.Queries;
using MassTransit;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Highway.Fee.Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeeController : ControllerBase
    {
        private IMediator _mediator;
        private readonly IBus _bus;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpPost("entry")]
        public async Task<IActionResult> CheckFee()
        {
            var dateToIssue = DateTime.UtcNow;
            var response = await _bus.Request<TicketRequestQuery, TicketRequestQueryResult>(new TicketRequestQuery
            { DateIssued = dateToIssue });
            return Ok(response);
            //return Ok(await Mediator.Send(new TicketRequestQuery { DateIssued = dateToIssue }));
        }
    }
}
