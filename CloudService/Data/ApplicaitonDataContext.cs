using Microsoft.EntityFrameworkCore;

namespace CloudService.Data
{
    public class ApplicaitonDataContext : DbContext
    {
        public ApplicaitonDataContext(DbContextOptions<ApplicaitonDataContext> options) : base(options)
        {

        }

        public DbSet<Models.Entities.Citis> Citis { get; set; }
    }
       
}
