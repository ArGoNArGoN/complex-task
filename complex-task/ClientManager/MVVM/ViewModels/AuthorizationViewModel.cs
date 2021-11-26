using ClientManager.MVVM.Architecture;
using ClientManager.MVVM.Models;
using ClientManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.MVVM.ViewModels
{
	internal class AuthorizationViewModel
		: BaseViewModel
	{
		private EmployeeModel user;
		private AuthorizationModel authorizationModel;

		private IAuthorizationServise servise;
		private ISaveDate<AuthorizationModel> saveService;

		public AuthorizationViewModel(IAuthorizationServise servise)
			: base()
		{
			if (authorizationModel is null)
				authorizationModel = new AuthorizationModel();
			this.servise = servise;
			SaveCommand?.Execute(true);
		}
		public AuthorizationViewModel(IAuthorizationServise servise, AuthorizationModel user)
			: this(servise)
		{
			authorizationModel = user ?? new AuthorizationModel();
		}
        public AuthorizationViewModel(IAuthorizationServise servise, ISaveDate<AuthorizationModel> saveService) 
			: this(servise)
        {
            this.saveService = saveService;
        }
		public AuthorizationViewModel(IAuthorizationServise servise, ISaveDate<AuthorizationModel> saveService, AuthorizationModel user)
			: this(servise, saveService)
        {
			authorizationModel = user ?? new AuthorizationModel();
		}

		public String ErrorMessage { get; set; } = "";

        public String Login
		{
            get { return authorizationModel.Login; }
            set { authorizationModel.Login = value; }
        }
		public String Password
		{
			get { return authorizationModel.Password; }
			set { authorizationModel.Password = value; }
		}
        public Boolean IsSaveLoginAndPassword
		{
            get { return authorizationModel.IsSaveLoginAndPassword; }
			set { authorizationModel.IsSaveLoginAndPassword = value; }
        }

        public event Action<EmployeeModel> CloseChanged;
		private event Action<AuthorizationModel> SaveChanged;
		
		public Command AuthorizationCommand { get; private set; }
		public Command SaveCommand { get; private set; }

		protected override void OnInitializationCommand()
		{
			AuthorizationCommand = new Command(Close, Authorization);

			SaveCommand = new Command((ob) =>
			{
				if ((Boolean?)ob == true)
				{
					SaveChanged += SaveUserData;
					SaveChanged -= DeleteUserData;
				}
				else
				{
					SaveChanged += DeleteUserData;
					SaveChanged -= SaveUserData;
				}
			});
		}

        private void DeleteUserData(AuthorizationModel obj)
		{
			saveService?.Delete(obj);
		}
        private void SaveUserData(AuthorizationModel ob)
        {
			saveService?.Save(ob);
		}

		private Boolean Authorization(object arg)
		{
			var isValid = false;

			if (!authorizationModel.IsValid)
			{
				ErrorMessage = "Некорректные данные!";
			}
			else
			{
				try
				{
					user = servise.Authorization(authorizationModel);
					isValid = true;
				}
				catch (Exception e)
				{
					ErrorMessage = e.Message;
				}
			}

			if (!isValid)
            {
                OnPropertyChanged(nameof(ErrorMessage));
            }

            return isValid;
		}

		private void Close(Object ob)
		{
			SaveChanged?.Invoke(authorizationModel);
			CloseChanged?.Invoke(user);
		}
	}
}
