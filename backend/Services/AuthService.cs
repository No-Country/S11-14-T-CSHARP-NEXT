using Microsoft.AspNetCore.Identity;
using S11.Common.Dtos.Auth;
using S11.Common.Interfaces;
using S11.Data.Models;

namespace S11.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly TokenService _tokenService;
        private readonly RoleManager<Role> _roleManager;

        public AuthService(UserManager<User> userManager, TokenService tokenService, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _tokenService = tokenService;
        }

        public async Task<LoginResponseDto> Login(string username, string password)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(username);
                if (user is null)
                {
                    return new LoginResponseDto
                    {
                        Message = "User not found",
                        IsValid = false,
                        Token = ""
                    };
                }

                var isPasswordMatch = await _userManager.CheckPasswordAsync(user, password);
                if (isPasswordMatch)
                {
                    //var roles = _roleManager.
                    var roles = await _userManager.GetRolesAsync(user);
                    var token = await _tokenService.GenerateToken(user);
                    return new LoginResponseDto
                    {
                        UserName = user.UserName ?? String.Empty,
                        FullName = user.FullName ?? String.Empty,
                        ImageUrl = user.ImageUrl ?? String.Empty,
                        Role = String.Join("|", roles),
                        IsValid = true,
                        Token = token
                    };
                }
                else
                {
                    return new LoginResponseDto
                    {
                        Message = "Invalid Credentials",
                        IsValid = false,
                        Token = ""
                    };
                }
            }
            catch (Exception e)
            {
                return new LoginResponseDto
                {
                    Message = "No Users on DB",
                    IsValid = false,
                };
            }
        }

        public async Task CreateTestUsers()
        {
            if (!_userManager.Users.Any(x => x.NormalizedEmail == "USER@EXAMPLE.COM"))
            {
                for (int i = 0; i < 5; i++)
                {
                    var genre = i % 2 == 0 ? "women" : "men";
                    var user = new User()
                    {
                        Email = $"user{(i == 0 ? "" : i)}@example.com",
                        UserName = $"user{(i == 0 ? "" : i)}@example.com",
                        FullName = $"user{(i == 0 ? "" : i)}",
                        ImageUrl = $"https://randomuser.me/api/portraits/{genre}/2.jpg"
                    };

                    var r = await _userManager.CreateAsync(user);
                    await _userManager.AddPasswordAsync(user, "string");
                }
            }
        }

        public void RestorePassword(string username)
        {
            throw new NotImplementedException();
        }
    }
}