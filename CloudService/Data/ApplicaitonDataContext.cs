using Microsoft.EntityFrameworkCore;

namespace CloudService.Data
{
    public class ApplicaitonDataContext : DbContext
    {
       static public ApplicaitonDataContext _AppDbContext; 



        public ApplicaitonDataContext(DbContextOptions<ApplicaitonDataContext> options) : base(options)
        {
             ApplicaitonDataContext._AppDbContext = this;
        }

        public DbSet<Models.Entities.Citis> Citis { get; set; }
    }
       
}
