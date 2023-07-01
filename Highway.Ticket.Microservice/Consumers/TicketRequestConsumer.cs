using Highway.Ticket.Microservice.Queries;
using MassTransit;

namespace Highway.Ticket.Microservice.Consumers
{
    public class TicketRequestConsumer : IConsumer<TicketRequestQuery>
    {
        private readonly ILogger<TicketRequestConsumer> _logger;

        public TicketRequestConsumer(ILogger<TicketRequestConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<TicketRequestQuery> context)
        {
            _logger.LogInformation("Received query: {Query}", context.Message);

            // Return the query result
            return context.RespondAsync<TicketRequestQueryResult>(new TicketRequestQueryResult
            {
                LicensePlates = new List<string> { "PZ123", "ZS123" }
            });
        }
    }
}
