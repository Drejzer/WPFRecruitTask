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
        public ShellViewModel()
            {
            _employees = new BindableCollection<EmployeeModel>();
            _employees.Add(new EmployeeModel() { ID = 0, Name = "Gal", Surname = "Anonim" });
            _employees.Add(new EmployeeModel() { ID = 1, Name = "Jan", Surname = "Kowalski" });
            _employees.Add(new EmployeeModel() { ID = 2, Name = "Włodzimież", Surname = "Konstantypolitańczykiewicz" });
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
