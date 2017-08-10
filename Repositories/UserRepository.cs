using System;
using Microsoft.EntityFrameworkCore;
using ZenLeapApi.Models;
using EF_Core_Generics.Repos;

namespace ZenLeapApi.Repositories
{
    public class UserRepository: GenericRepository<User>
    {
        public UserRepository(DbContext context)
            :base(context){
        }
    }
}
