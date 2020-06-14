using PM_Model.Common;
using System;

namespace PM_Model.Models
{
    public class Task_log : BaseEntity
    {
        public string TaskId { get; set; }
        public string Task_Desription { get; set; }
        public string ProjectId { get; set; }
        public DateTime Task_log_Date { get; set; }
        public int Minutes { get; set; }
    }
}
