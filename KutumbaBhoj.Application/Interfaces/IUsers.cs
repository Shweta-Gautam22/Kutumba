using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services
{
    public interface IUsers
    {
        
            Task<List<User>> GetAllUsers();

            Task<List<User>> AddUsers(User i);

            Task<User> GetSingleUser(int id);

            Task<User> UpdateUser(int id, User Request);

            Task<List<User>> DeleteUser(int id);

    }
}
