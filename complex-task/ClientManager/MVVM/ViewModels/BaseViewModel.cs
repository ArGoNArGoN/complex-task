using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClientManager.MVVM.ViewModels
{
    internal abstract class BaseViewModel
        : INotifyPropertyChanged
    {
        protected BaseViewModel()
        {
            OnInitializationCommand();
        }

        protected abstract void OnInitializationCommand();

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Обнавляет View по свойству
        /// </summary>
        /// <param name="prop">
        /// Имя обновляемого свойства
        /// </param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}