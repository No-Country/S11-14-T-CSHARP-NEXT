using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S11.Common.Dto.Auth;
using S11.Data.Models;
using S11.Services;
using System.Drawing;

namespace HotelWiz.Areas.Auth.Pages
{
    public class Login : PageModel
    {
        [BindProperty]
        public LoginPostDto LoginModel { get; set; }

        public string RedirecTo = string.Empty;

        private readonly AuthService _authService;
        public Login(AuthService authService)
        {
            _authService = authService;
        }

        public async Task<IActionResult> OnPostAsync(string? redirectTo)
        {
            if (ModelState.IsValid)
            {
                var loggedIn = await _authService.LoginWithUserPassword(LoginModel.UserName, LoginModel.Password);
                if (loggedIn.IsValid)
                {
                    return LocalRedirect($"~/{redirectTo??RedirecTo}" );
                }
            }
            return Page();
        }
    }
}
