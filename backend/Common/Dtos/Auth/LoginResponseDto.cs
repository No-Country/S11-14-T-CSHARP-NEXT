namespace S11.Common.Dtos.Auth
{
    public class LoginResponseDto
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public bool IsValid { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }

    }
}
