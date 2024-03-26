using KutumbaBhoj.Application.Interfaces;
using KutumbaBhoj.Domain.Models;

namespace KutumbaBhoj.Application.Services
{
    public class ServiceUsers:IUsers
    {
        private readonly IUserRepository _users;

        public ServiceUsers(IUserRepository users)
        {
            _users = users;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _users.GetAllUsers();
        }

        public async Task<List<User>> AddUsers(User I)
        {
            return await _users.AddUsers(I);
        }

        public async Task<User> GetSingleUser(int Id)
        {
            return await _users.GetSingleUser(Id);
        }

        public async Task<User> UpdateUser(int Id, User Request)
        {
            return await _users.UpdateUser(Id, Request);
        }

        public async Task<List<User>> DeleteUser(int Id)
        {
            return await _users.DeleteUser(Id);
        }
    }
}

