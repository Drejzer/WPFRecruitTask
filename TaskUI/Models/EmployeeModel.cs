using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace TaskUI.Models
    {
    public class EmployeeModel
        {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ID { get; set; }
        public List<WorkTaskModel> UnfinishedTasks { get; set; }

        public int UnfinishedTasksCount
            {
            get
                {
                return UnfinishedTasks.Count();
                }
            }
        }
    }
