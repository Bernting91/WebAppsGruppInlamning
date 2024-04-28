using Microsoft.EntityFrameworkCore;

namespace WebAppsGruppInlamning.Objects
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Car> Cars { get; set; }
        
        public DbSet<Modification> Modifications { get; set; }
    }
}
