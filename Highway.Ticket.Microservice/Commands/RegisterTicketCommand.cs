using Highway.Ticket.Microservice.Context;
using Highway.Ticket.Microservice.Entities;
using MediatR;

namespace Highway.Ticket.Microservice.Requests
{
    public class RegisterTicketCommand : IRequest<int>
    {
        public string LicensePlate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public class RegisterTicketCommandHandler : IRequestHandler<RegisterTicketCommand, int>
        {
            private readonly IApplicationDbContext _context;

            public RegisterTicketCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(RegisterTicketCommand command, CancellationToken cancellationToken)
            {
                var entity = new TicketPayment();
                entity.LicencePlate = command.LicensePlate;
                entity.StartDate = command.StartDate;
                entity.EndDate = command.EndDate;

                _context.TicketPayments.Add(entity);
                await _context.SaveChanges();
                return entity.Id;
            }
        }
    }
}
