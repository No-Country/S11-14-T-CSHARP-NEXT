using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using S11.Data.Models;

namespace S11.Data.Seeds
{
    public class UserSeed
    {
        public static void Seed(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<User>();

            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "adminPassword"), // Hash de la contraseña
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = "CONCURRENCY_STAMP"
                },
                new User
                {
                    Id = 2,
                    UserName = "user1",
                    NormalizedUserName = "USER1",
                    Email = "user1@gmail.com",
                    NormalizedEmail = "USER1@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password"), // Hash de la contraseña
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = "CONCURRENCY_STAMP"
                },
                new User
                {
                    Id = 3,
                    UserName = "user2",
                    NormalizedUserName = "USER2",
                    Email = "user2@gmail.com",
                    NormalizedEmail = "USER2@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password"), // Hash de la contraseña
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = "CONCURRENCY_STAMP"
                }
            );
        }
    }
}
