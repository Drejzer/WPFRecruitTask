using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskUI.Models
    {
    public class DetailDisplayModel
        {
        public DetailDisplayModel()
            {
            NameString = "Dane: ";
            IdString = "Identyfikator: ";
            UnfinishedTasks = new List<WorkTaskModel>();
            }
        public DetailDisplayModel(EmployeeModel selected)
            {
            NameString = "Dane: " + selected.Name + " " + selected.Surname;
            IdString = "Identyfikator: " + selected.ID;
            UnfinishedTasks = selected.UnfinishedTasks;
            }
        public string NameString { get; private set; }
        public string IdString { get; private set; }
        public List<WorkTaskModel> UnfinishedTasks { get; private set; }
        }
    }
