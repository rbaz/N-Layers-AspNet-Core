using PM_Model.Common;
using System;
using System.Collections.Generic;

namespace PM_Model.Models
{
    public class UserStorie: BaseEntity
    {
        //public int UserStorieId { get; set; }
        public string Story { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Date_Creation { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Estimation_EndDate { get; set; }
        public DateTime Real_Enddate { get; set; }
        //Foreign key for Project
        public int ProjectId { get; set; }
        public virtual Project Projects { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
