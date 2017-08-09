using System.Collections.Generic;

namespace ZenLeapApi.Models
{
	public class User
	{
		public int Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; } 

        public ICollection<Project> Projects { get; set; }
	}
}