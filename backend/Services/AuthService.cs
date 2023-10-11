using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Azure;
using S11.Common.Dtos.Auth;
using S11.Common.Interfaces;
using S11.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace S11.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly TokenService _tokenService;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;


        public AuthService(UserManager<User> userManager, TokenService tokenService, RoleManager<Role> roleManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _userManager = userManager;
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
                        Role = String.Join("|", roles),
                        IsValid = true,
                        Token = token
                    };
                }
                return new LoginResponseDto
                {
                    IsValid = false,
                    Token = ""
                };
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
            if (!_userManager.Users.Any())
            {
                for (int i = 0; i < 5; i++)
                {
                    var user = new User()
                    {
                        Email = $"user{(i == 0?"":i)}@example.com",
                        UserName = $"user{i + 1}@example.com",
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
