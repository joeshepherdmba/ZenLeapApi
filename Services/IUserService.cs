using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZenLeapApi.Models;
using ZenLeapApi.TransferObjects;

namespace ZenLeapApi.Services
{
    public interface IUserService
    {
		Task<User> CreateUserAsync(UserDto user);
		Task<User> LoginAsync(UserDto user);
        Task<ICollection<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<User> GetUserByEmailAsync(string email);
        Task<User> UpdateUserAsync(UserDto user);
        Task<int> DeleteUserAsync(UserDto user);
	}
}
