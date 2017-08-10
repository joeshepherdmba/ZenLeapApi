using System;
using Microsoft.EntityFrameworkCore;
using ZenLeapApi.Models;
using EF_Core_Generics.Repos;
using System.Threading.Tasks;

namespace ZenLeapApi.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context)
            :base(context){
        }

        public Task<User> LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> RegisterAsync(string email, string password, string confirmPassword)
        {
            throw new NotImplementedException();
        }
    }
}
