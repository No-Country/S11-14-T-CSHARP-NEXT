using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using S11.Data.Models;

namespace S11.Data.Seeds
{
    public class RoleSeed
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new Role
                {
                    Id = 2,
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
}
