using Microsoft.EntityFrameworkCore;

namespace ContractMonthlyClaimSystem.Models
{
    public class ClaimDbContext : DbContext
    {
        public DbSet<Claim> Claims { get; set; }

        public ClaimDbContext(DbContextOptions<ClaimDbContext> options) : base(options) 
        {
            
        }
    }
}