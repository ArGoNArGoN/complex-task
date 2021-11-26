using ClientManager.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.MVVM.ViewModels
{
    class MainWindowViewModel
        : BaseViewModel
    {
        private EmployeeModel employee;

        public MainWindowViewModel(EmployeeModel employee)
        {
            this.employee = employee;
        }

        protected override void OnInitializationCommand()
        {

        }
    }
}
