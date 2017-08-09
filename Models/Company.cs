using System;
using System.Collections;
using System.Collections.Generic;

namespace ZenLeapApi.Models
{
    public class Company{
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateEstablished { get; set; }
        public User Owner { get; set; }

        public virtual ICollection<Project> Projects { get; set; } 

    }    
}
