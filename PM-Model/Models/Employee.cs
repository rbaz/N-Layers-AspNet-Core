using PM_Model.Common;
using System.Collections.Generic;

namespace PM_Model.Models
{
    public class Employee : BaseEntity
    {
        //public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Designation { get; set; }
        public string Role { get; set; }
        public int ManagedId { get; set; }        
        public string ContactId { get; set; }       
        public string DepartmentId { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

    }
}
