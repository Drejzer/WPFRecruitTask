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

        private EmployeeModel _selectedEmployee;
        private DetailDisplayModel _detailDisplay;

        public EmployeeModel SelectedEmployee
            {
            get { return _selectedEmployee; }
            set 
                { 
                _selectedEmployee = value;
                NotifyOfPropertyChange(() => SelectedEmployee);
                DetailDisplay = new DetailDisplayModel(SelectedEmployee);
                }
            }

        public DetailDisplayModel DetailDisplay
            {
            get
                {
                return _detailDisplay;
                }
            set
                {
                _detailDisplay = value;
                NotifyOfPropertyChange(()=>DetailDisplay);
                }
            }
        public ShellViewModel()
            {
            DetailDisplay = new DetailDisplayModel();
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
