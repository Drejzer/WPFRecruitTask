using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskDB.Models
    {
    public class WorkTask
        {
        public int WorkTaskId { get; set; }
        public string WorkTaskDescription { get; set; }
        public virtual ICollection<Employee> AssignedEmployees { get; set; }
        public WorkTaskType WorkTaskType { get; set; }
        public int WorkTaskTypeId { get; set; }
        public bool IsCompleted { get; set; }

        }
    }
