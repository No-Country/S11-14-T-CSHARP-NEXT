using HotelWiz.Back.Common.Dto.Auth;

namespace HotelWiz.Back.Common.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto> Login(string username, string password);
        Task RestorePassword(string username);
        Task CreateTestUsers();

    }
}
