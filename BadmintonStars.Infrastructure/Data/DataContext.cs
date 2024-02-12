using BadmintonStars.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BadmintonStars.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<PlayerModel> Players { get; set; }
    }
}
 