using Microsoft.EntityFrameworkCore;
using FootBallLeage.Models;
namespace FootBallLeage.Data
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        { 
        
        }
        public DbSet<FootBallModel> FootBallLeages { get; set; } = null!;
    }
}
