using ClientManager.MVVM.Models;
using ClientManager.MVVM.ViewModels;
using ClientManager.MVVM.Views;
using ClientManager.Service;
using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace ClientManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
        : Application
    {
        private readonly ISaveDate<AuthorizationModel> servise;
        private AuthorizationViewModel vm;
        private Window logInWindow;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var user = servise?.Get() ?? new AuthorizationModel()
            {
                IsSaveLoginAndPassword = false,
            };

            vm = new AuthorizationViewModel(new AuthorizationServise(), user);

            vm.CloseChanged += OpenMainWindow;

            logInWindow = new AuthorizationView()
            {
                DataContext = vm,
            };

            logInWindow.Show();
        }

        private void OpenMainWindow(EmployeeModel obj)
        {
            if (obj is null)
                return;

            var window = new MainWindow()
            {
                DataContext = new MainWindowViewModel(obj),
            };

            window.Show();

            logInWindow.Close();
        }
    }
}
