using System.ComponentModel.DataAnnotations;

namespace S11.Common.Dtos.Auth
{
    public class LoginPostDto
    {
        [EmailAddress]
        public string UserName { get; set; }
        //politicas del password
        public string Password { get; set; }

    }
}
