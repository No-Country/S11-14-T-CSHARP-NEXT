using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using S11.Data.Models;

namespace S11.Data
{
    public class Contexto: IdentityDbContext<User, Role, int>
    {
        public Contexto(DbContextOptions options): base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            Seeds.Issues.Seed(builder);

        }

        public virtual   DbSet<Issue> Issues { get; set;}
    }
}
