using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Caliburn.Micro;

namespace TaskUI.ViewModels
    {
    public class ShellViewModel:Screen
        {
        private string _name;
        public string Name
            {
            get
                {
                return _name;
                }
            set
                {
                _name = value;
                NotifyOfPropertyChange(()=>Name);
                }
            }
        }
    }
