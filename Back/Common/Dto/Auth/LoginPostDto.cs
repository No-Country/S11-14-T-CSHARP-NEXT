using System.ComponentModel.DataAnnotations;

namespace HotelWiz.Back.Common.Dto.Auth
{
    public class LoginPostDto
    {
        [EmailAddress]
        public string UserName { get; set; }
        //politicas del password
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
