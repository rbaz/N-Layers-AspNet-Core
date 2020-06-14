using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;

namespace PM_Model.Models
{
    public class EmployeeProfile
    {
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; } 
        public DateTime DateStartWork { get; set; }
        public DateTime DateEndWork { get; set; }
        public string ScholarizationId { get; set; }
        public string ExperienceId { get; set; }

    }
}
