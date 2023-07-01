using Highway.Gate.Microservice.Entities;
using Microsoft.EntityFrameworkCore;

namespace Highway.Gate.Microservice.Context
{
    public interface IApplicationDbContext
    {
        DbSet<EntryRegistry> EntryRegistries { get; set; }
        DbSet<ExitRegistry> ExitRegistries { get; set; }

        Task<int> SaveChanges();
    }
}