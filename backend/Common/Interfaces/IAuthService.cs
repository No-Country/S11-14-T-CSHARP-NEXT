using S11.Common.Dto.Auth;

namespace S11.Common.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto> Login(string username, string password);
        Task RestorePassword(string username);
        Task CreateTestUsers();

    }
}
