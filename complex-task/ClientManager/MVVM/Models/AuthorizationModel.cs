using System;

namespace ClientManager.MVVM.Models
{
    /// <summary>
    /// Модель авторизации пользователя
    /// </summary>
    [Serializable]
    public class AuthorizationModel
        : BaseModel
    {
        private String login = "";
        private String password = "";

        public AuthorizationModel()
            : base() { }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public String Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged(nameof(Login));
            }
        }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public String Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private Boolean isSaveLoginAndPassword;
        public Boolean IsSaveLoginAndPassword
        {
            get { return isSaveLoginAndPassword; }
            set
            {
                isSaveLoginAndPassword = value;
                OnPropertyChanged(nameof(IsSaveLoginAndPassword));
            }
        }

        public override Boolean IsValid 
            => Login.Length > 5 
            && Password.Length > 5;
    }
}
