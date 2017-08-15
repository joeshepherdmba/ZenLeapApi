using System;
using System.Collections.Generic;
using ZenLeapApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenLeapApi.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public double ProjectValue { get; set; }
        public double VelocityFactor { get; set; }
        public double HealthFactor { get; set; }

		public int ProjectOwnerId { get; set; }

        [ForeignKey("ProjectOwnerId")]
        public virtual User ProjectOwner { get; set; }

        public int CompanyId { get; set; }
		
        [ForeignKey("CompanyId")]
		public Company Company { get; set; }

        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}
