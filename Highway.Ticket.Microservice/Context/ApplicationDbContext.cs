using Highway.Ticket.Microservice.Entities;
using Microsoft.EntityFrameworkCore;

namespace Highway.Ticket.Microservice.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<TicketPayment> TicketPayments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
