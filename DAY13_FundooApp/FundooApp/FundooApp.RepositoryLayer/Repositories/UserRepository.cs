using FundooApp.ModelLayer.Entities;
using FundooApp.RepositoryLayer.Context;
using FundooApp.RepositoryLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FundooApp.RepositoryLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get user by email
        public async Task<User?> GetUserByEmail(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        // Register user
        public async Task<User?> RegisterUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        // Login - find user only by email
        public async Task<User?> LoginUser(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}