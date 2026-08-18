using FundooApp.ModelLayer.Entities;

namespace FundooApp.RepositoryLayer.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> RegisterUser(User user);

        Task<User?> LoginUser(string email, string password);

        Task<User?> GetUserByEmail(string email);
    }
}