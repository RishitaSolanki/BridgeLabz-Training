namespace FundooApp.BusinessLayer.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(int userId, string email);
    }
}