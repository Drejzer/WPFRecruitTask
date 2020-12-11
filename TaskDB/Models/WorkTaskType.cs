using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskDB.Models
    {
    public class WorkTaskType
        {
        public int WorkTasktTypeId { get; set; }
        public string WorkTaskTypeName { get; set; }
        public virtual ICollection<WorkTask> WorkTasks { get; set; }
        }
    }
