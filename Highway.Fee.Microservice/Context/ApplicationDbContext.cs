using Highway.Fee.Microservice.Entities;
using Microsoft.EntityFrameworkCore;

namespace Highway.Fee.Microservice.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<FeeIssued> Fees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
