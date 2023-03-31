using Microsoft.EntityFrameworkCore;

namespace WebApps.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
    }  
}
