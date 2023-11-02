namespace HotelWiz.Back.Common.Dto.Auth
{
    public class LoginResponseDto
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public bool IsValid { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }

        public string FullName { get; set; }

        public string ImageUrl { get; set; }

    }
}
