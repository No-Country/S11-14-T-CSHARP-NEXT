namespace S11.Common.Interfaces
{
    public interface IAuthService
    {
        object Login(string username, string password);
        void RestorePassword(string username);

    }
}
