using Highway.Gate.Microservice.Context;
using Highway.Gate.Microservice.Entities;
using MediatR;

namespace Highway.Gate.Microservice.Requests
{
    public class RegisterExitCommand : IRequest<int>
    {
        public string LicensePlate { get; set; }
        public int LicencePlateCorrectness { get; set; }

        public class RegisterExitCommandHandler : IRequestHandler<RegisterExitCommand, int>
        {
            private readonly IApplicationDbContext _context;

            public RegisterExitCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(RegisterExitCommand command, CancellationToken cancellationToken)
            {
                var entity = new ExitRegistry();
                entity.LicencePlate = command.LicensePlate;
                entity.LicencePlateCorrectness = command.LicencePlateCorrectness;
                entity.RegistryDate = DateTime.UtcNow;

                _context.ExitRegistries.Add(entity);
                await _context.SaveChanges();
                return entity.Id;
            }
        }
    }
}
