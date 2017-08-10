using System;
using System.Threading.Tasks;
using ZenLeapApi.Models;

namespace ZenLeapApi.Repositories
{
    public interface IUserRepository
    {
        Task<User> RegisterAsync(string email, string password, string confirmPassword);
        Task<User> LoginAsync(string email, string password);
    }
}
