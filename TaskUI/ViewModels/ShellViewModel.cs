﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using Caliburn.Micro;
using TaskUI.Models;
using TaskDB;
using System.Windows.Data;

namespace TaskUI.ViewModels
    {

    public class ShellViewModel:Screen
        {
        private BindableCollection<EmployeeModel> _employees;
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

        public BindableCollection<EmployeeModel> Employees
            {
            get { return _employees; }
            set {
                _employees = value;
                NotifyOfPropertyChange(() => Employees);
                }
            }

        public ShellViewModel()
            {
            DetailDisplay = new DetailDisplayModel();
            _employees = _getEmployees();
            }

        private BindableCollection<EmployeeModel> _getEmployees()
            {
            /*
             * Placeholder implementation for testing
             * normally data is retrieved from the DB
             */
            var tab=new BindableCollection<EmployeeModel>()
                {
                new EmployeeModel()
                    {
                    ID = 0,
                    Name = "Gal",
                    Surname = "Anonim",
                    UnfinishedTasks = new List<WorkTaskModel>()
                        {
                        new WorkTaskModel(){ WorkTaskID = 1, Description="Zadanie 1", Category="Test zadań" },
                        new WorkTaskModel(){ WorkTaskID = 2, Description="Zadanie 2", Category="test zadań"}
                        }
                    },
                new EmployeeModel()
                    {
                    ID = 1,
                    Name = "Jan",
                    Surname = "Kowalski",
                    UnfinishedTasks = new List<WorkTaskModel>()
                        {
                        new WorkTaskModel(){ WorkTaskID = 12, Description="Zadanie 12", Category="Test zadań" },
                        new WorkTaskModel(){ WorkTaskID = 3, Description="Zadanie 3", Category="test zadań"}
                        }
                    },
                new EmployeeModel()
                    {
                    ID = 224,
                    Name = "Włodzimież",
                    Surname = "Konstantypolitańczykiewicz",
                    UnfinishedTasks = new List<WorkTaskModel>()
                        {
                        new WorkTaskModel(){ WorkTaskID = 123, Description="Zadanie 123", Category="Test zadań" },
                        new WorkTaskModel(){ WorkTaskID = 4, Description="Zadanie 4", Category="test zadań"},
                        new WorkTaskModel(){ WorkTaskID = 5, Description="Zadanie 5", Category="test zadań"}
                        }
                    }
                };
            return tab;
            }

        public void RemoveEmployee(int id)
            {
            //Placeholder
            Console.WriteLine("remove button Pressed");
            //remove_from_database(id)

            Employees = _getEmployees();
            }

        public void AddEmployee()
            {
            //Placeholder 
            Console.WriteLine("Add button Pressed");
            // dialog do wprowadzenia danych

            // add_to_database

            Employees = _getEmployees();
            }
        }
    }
