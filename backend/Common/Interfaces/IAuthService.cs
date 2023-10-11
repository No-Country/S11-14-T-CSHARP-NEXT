using S11.Common.Dtos.Auth;

namespace S11.Common.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto> Login(string username, string password);
        void RestorePassword(string username);
        Task CreateTestUsers();

    }
}
