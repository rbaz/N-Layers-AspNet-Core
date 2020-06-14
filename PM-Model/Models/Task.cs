using PM_Model.Common;
using System;

namespace PM_Model.Models
{
    public class Task : BaseEntity
    {
        //public int ProjectTaskId { get; set; }
        public string Description { get; set; }
        //Foreign key for Employee
        public int AssignedTo { get; set; }
        public virtual Employee Employees { get; set; }

        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int TaskCompletion { get; set; }

        //Foreign key for UserStorie
        public int UserStorieId { get; set; }
        public virtual UserStorie UserStories { get; set; }
    }
}
