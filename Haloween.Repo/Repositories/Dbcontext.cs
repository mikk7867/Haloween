using Haloween.Repo.DTO;
using Microsoft.EntityFrameworkCore;

namespace Haloween.Repo.Repositories
{
    public class Dbcontext : DbContext // EF CORE
    {
        //a class has 2 things (methods and properties)
        public Dbcontext(DbContextOptions<Dbcontext> option) : base(option)
        {

        }

        public DbSet<SuperHero> SuperHero { get; set; }

        public DbSet<Team> Team { get; set; }
    }
}
