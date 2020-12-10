using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using Caliburn.Micro;
using TaskUI.Models;

namespace TaskUI.ViewModels
    {
    public class ShellViewModel:Screen
        {
        public DetailDisplayModel DetailDisplay=new DetailDisplayModel();
        public ShellViewModel()
            {
            //test display
            _employees = new BindableCollection<EmployeeModel>
                {
                new EmployeeModel() { ID = 0, Name = "Gal", Surname = "Anonim", UnfinishedTasks = new List<WorkTaskModel>() },
                new EmployeeModel() { ID = 1, Name = "Jan", Surname = "Kowalski", UnfinishedTasks = new List<WorkTaskModel>() },
                new EmployeeModel() { ID = 2, Name = "Włodzimież", Surname = "Konstantypolitańczykiewicz", UnfinishedTasks = new List<WorkTaskModel>() }
                };
            }
        private BindableCollection<EmployeeModel> _employees;

        public BindableCollection<EmployeeModel> Employees
            {
            get { return _employees; }
            set {
                _employees = value;
                NotifyOfPropertyChange(() => Employees);
                }
            }
        }
    }
