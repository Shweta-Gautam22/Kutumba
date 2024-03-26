using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;
using KutumbaBhoj.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;

namespace KutumbaBhoj.Infrastructure.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly DataContext _dbContext;

        public UserRepository(DataContext DbContext)
        {
            _dbContext = DbContext;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> AddUsers(User i)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(i.Password);
            i.Password = passwordHash;

            _dbContext.Users.Add(i);
            await _dbContext.SaveChangesAsync();

            return i;
        }

        public async Task<User> GetSingleUser(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task<User> UpdateUser(int id, User request)
        {
            User existingUser = await _dbContext.Users.FindAsync(id);
            if (existingUser != null)
            {
                existingUser.Username = request.Username;
                existingUser.Password = request.Password;
                await _dbContext.SaveChangesAsync();
            }
            return existingUser;
        }

        public async Task<List<User>> DeleteUser(int id)
        {
            User existingUser = await _dbContext.Users.FindAsync(id);
            if (existingUser != null)
            {
                _dbContext.Users.Remove(existingUser);
                await _dbContext.SaveChangesAsync();
            }
            return await _dbContext.Users.ToListAsync();
        }

        Task<List<User>> IUserRepository.AddUsers(User user)
        {
            throw new NotImplementedException();
        }
    }
}
