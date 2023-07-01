using Highway.Gate.Microservice.Entities;
using Microsoft.EntityFrameworkCore;

namespace Highway.Gate.Microservice.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<EntryRegistry> EntryRegistries { get; set; }
        public DbSet<ExitRegistry> ExitRegistries { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
