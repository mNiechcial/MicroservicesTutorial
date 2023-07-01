using Highway.Fee.Microservice.Entities;
using Microsoft.EntityFrameworkCore;

namespace Highway.Fee.Microservice.Context
{
    public interface IApplicationDbContext
    {
        DbSet<FeeIssued> Fees { get; set; }

        Task<int> SaveChanges();
    }
}