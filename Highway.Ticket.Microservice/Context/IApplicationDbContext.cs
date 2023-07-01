using Highway.Ticket.Microservice.Entities;
using Microsoft.EntityFrameworkCore;

namespace Highway.Ticket.Microservice.Context
{
    public interface IApplicationDbContext
    {
        DbSet<TicketPayment> TicketPayments { get; set; }

        Task<int> SaveChanges();
    }
}