using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZenLeapApi.Data;
using ZenLeapApi.Models;
using ZenLeapApi.TransferObjects;

namespace ZenLeapApi.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(DataContext context)
        : base(context)
        {
        }

        public Task<User> CreateUserAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteUserAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> LoginAsync(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
