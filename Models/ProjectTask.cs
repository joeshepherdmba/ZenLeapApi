using System;
using System.Collections.Generic;
using static ZenLeapApi.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZenLeapApi.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
       
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EstHours { get; set; }
        public int AssignedToUserID { get; set; }

        public virtual Project Project { get; set; }
        public virtual User AssignedToUserId { get; set; }
        //public virtual ICollection<TimeEntry> TimeEntry { get; set; }
    }
}
