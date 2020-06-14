using PM_Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PM_Model.Models
{
    public class Project : BaseEntity
    {
        //public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string CustomerName { get; set; }
        public virtual ICollection<UserStorie> UserStories { get; set; }
    }
}
