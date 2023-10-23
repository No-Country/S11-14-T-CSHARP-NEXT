using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using S11.Data.Models;
using S11.Data.Seeds;

namespace S11.Data
{
    public class Contexto : IdentityDbContext<User, Role, int>
    {
        public Contexto(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            Seeds.Issues.Seed(builder);
            Seeds.RoomSeed.Seed(builder);
            // Llamar a las clases de semilla para roles y usuarios
            RoleSeed.Seed(builder);
            UserSeed.Seed(builder);

            ReservationsSeed.Seed(builder);

        }

        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }

        public virtual DbSet<Room> Rooms { get; set; }
    }
}
