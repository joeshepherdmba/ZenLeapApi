using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ZenLeapApi.Data;
using ZenLeapApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
// https://stormpath.com/blog/5-api-tips-dotnet-core Use this for Core

namespace ZenLeapApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController :Controller
    {
        protected UnitOfWork _unitOfWork;
        protected DataContext _context;

        public UsersController()
            : base()
        {
            _context = new DataContext();
            _unitOfWork = new UnitOfWork(_context);
        }

        // GET: api/users        
        [HttpGet]
        public IEnumerable<User> Get()
        {
            //return new string[] { "value1", "value2" };
            return _unitOfWork.UserRepository.GetAll();
            //var repo = _unitOfWork.UserRepository;

            //List<User> users = new List<User>();
            //users.Add(new User{
            //    Email = "test@test.com"
            //});

            //return users;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            //return _unitOfWork.UserRepository.GetById(id);
            //return "value";
            User user = new User()
            {
                Email = "test@test.com"
            };
            return user;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
