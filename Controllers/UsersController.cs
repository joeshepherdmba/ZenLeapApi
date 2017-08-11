using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ZenLeapApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
// https://stormpath.com/blog/5-api-tips-dotnet-core Use this for Core

namespace ZenLeapApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : BaseController
    {
        //protected UnitOfWork _unitOfWork;
        //protected DataContext _context;

        //public UsersController()
        //    : base()
        //{
        //    _context = new DataContext();
        //    _unitOfWork = new UnitOfWork(_context);
        //}

        // GET: api/users        
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _unitOfWork.UserRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _unitOfWork.UserRepository.GetById(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]User value)
        {
			if (value == null)
			{
				return BadRequest();
			}

            //User user = JsonConvert.DeserializeObject<User>(value);
			_unitOfWork.UserRepository.Add(value);
            _unitOfWork.UserRepository.SaveChanges();

            return Ok();
			//return CreatedAtRoute("GetBook", new { id = createdBook.Id }, createdBook);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]User value)
        {
			return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
			return Ok();
        }
    }
}
