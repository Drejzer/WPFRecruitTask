using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskDB.Models
    {
    public class Employee
        {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public virtual ICollection<WorkTask> WorkTasks { get; set; }
        }

    }
