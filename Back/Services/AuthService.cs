﻿using HotelWiz.Back.Common.Dto.Auth;
using HotelWiz.Back.Common.Interfaces;
using HotelWiz.Back.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace HotelWiz.Back.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly TokenService _tokenService;
        private readonly RoleManager<Role> _roleManager;
        private readonly EmailService _emailService;
        private readonly IConfiguration _configuration;

        public AuthService(SignInManager<User> signInManager, UserManager<User> userManager, TokenService tokenService, RoleManager<Role> roleManager, EmailService emailService, IConfiguration configuration)
        {
            _configuration = configuration;
            _userManager = userManager;
            _roleManager = roleManager;
            _tokenService = tokenService;
            _emailService = emailService;
            _signInManager = signInManager;
        }

        //TODO PasswordSignInAsync

        public async Task<LoginResponseDto> LoginWithUserPassword(string username, string password)
        {
            //    try
            {
                var loginResult = await _signInManager.PasswordSignInAsync(username, password, false, false);
                if (!loginResult.Succeeded)
                {
                    return new LoginResponseDto
                    {
                        Message = "User not found",
                        IsValid = false,
                        Token = ""
                    };
                }


                //  var user =
                return new LoginResponseDto
                {
                    IsValid = true
                    //UserName = username ?? String.Empty,
                    //FullName = user.FullName ?? String.Empty,
                    //ImageUrl = user.ImageUrl ?? String.Empty,
                    //Role = String.Join("|", roles),
                    //IsValid = true,
                    //Token = token
                };

                //   }
            }
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
                    var token = await _tokenService.GenerateToken(user, roles);
                    return new LoginResponseDto
                    {
                        UserName = user.UserName ?? string.Empty,
                        FullName = user.FullName ?? string.Empty,
                        ImageUrl = user.ImageUrl ?? string.Empty,
                        Role = string.Join("|", roles),
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
            //set role to admin
            var admin = await _userManager.FindByEmailAsync("admin@gmail.com");

            if (admin is not null && !await _userManager.IsInRoleAsync(admin, "Admin"))
            {
                var roleExists = await _roleManager.RoleExistsAsync("Admin");
                if (roleExists)
                {
                    var result = await _userManager.AddToRolesAsync(admin, new[] { "Admin" });
                }
            }

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
                        ImageUrl = $"https://randomuser.me/api/portraits/{genre}/{i + 1}.jpg"
                    };

                    var r = await _userManager.CreateAsync(user);
                    await _userManager.AddPasswordAsync(user, "string");
                }
            }
        }

        public async Task RestorePassword(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var encodedToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

                // Construir el enlace de restablecimiento de contraseña
                var resetPasswordLink = $"{_configuration["PasswordReset:ResetLink"]}?userId={user.Id}&token={encodedToken}";

                // Envía el enlace de restablecimiento de contraseña al usuario por correo electrónico
                var subject = "Restablecimiento de contraseña";
                var message = $"Haga clic en el siguiente enlace para restablecer su contraseña: <a href='{resetPasswordLink}'>Restablecer contraseña</a>";

                // Utiliza el servicio de correo electrónico para enviar el mensaje
                _emailService.SendEmail(user?.Email, subject, message);
            }
        }

    }
}