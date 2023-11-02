using HotelWiz.Back.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelWiz.Back.Data.Seeds
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
