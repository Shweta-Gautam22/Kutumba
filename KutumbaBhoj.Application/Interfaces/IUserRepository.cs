using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();

        Task<List<User>> AddUsers(User user);

        Task<User> GetSingleUser(int id);

        Task<User> UpdateUser(int id, User Request);

        Task<List<User>> DeleteUser(int id);


    }
}
