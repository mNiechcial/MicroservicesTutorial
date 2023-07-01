using Highway.Gate.Microservice.Context;
using Highway.Gate.Microservice.Entities;
using MediatR;

namespace Highway.Gate.Microservice.Requests
{
    public class RegisterEntranceCommand : IRequest<int>
    {
        public string LicensePlate { get; set; }
        public int LicencePlateCorrectness { get; set; }

        public class RegisterEntranceCommandHandler : IRequestHandler<RegisterEntranceCommand, int>
        {
            private readonly IApplicationDbContext _context;

            public RegisterEntranceCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<int> Handle(RegisterEntranceCommand command, CancellationToken cancellationToken)
            {
                var entity = new EntryRegistry();
                entity.LicencePlate = command.LicensePlate;
                entity.LicencePlateCorrectness = command.LicencePlateCorrectness;
                entity.RegistryDate = DateTime.UtcNow;

                _context.EntryRegistries.Add(entity);
                await _context.SaveChanges();
                return entity.Id;
            }
        }
    }
}
