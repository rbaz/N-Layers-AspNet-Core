using PM_Model.Common;
using System.Collections.Generic;

namespace PM_Model.Models
{
    class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Foreign key for Employee
        public string EmployeeId {get; set;}
        public virtual IEnumerable<Employee> Employees { get; set; }


    }
}
