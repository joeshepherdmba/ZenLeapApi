using System;
using System.Collections.Generic;
using ZenLeapApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenLeapApi.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [ForeignKey("ProjectOwner")]
        public int ProjectOwnerID { get; set; }
        public double ProjectValue { get; set; }
        public double VelocityFactor { get; set; }
        public double HealthFactor { get; set; }

		public User ProjectOwner { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}
