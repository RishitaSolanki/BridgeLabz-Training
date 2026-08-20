using FundooApp.ModelLayer.Entities;

namespace FundooApp.RepositoryLayer.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByEmail(string email);

        Task<User?> RegisterUser(User user);

        Task<User?> LoginUser(string email);
    }
}