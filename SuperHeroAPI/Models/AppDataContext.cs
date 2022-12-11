using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Models
{
    public class AppDataContext: DbContext
    {

        public AppDataContext(DbContextOptions<AppDataContext> options):base(options) 
        { 
        
        }
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
