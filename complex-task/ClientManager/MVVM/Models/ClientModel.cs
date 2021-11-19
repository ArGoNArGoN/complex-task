using System;

namespace ClientManager.MVVM.Models
{
	internal class ClientModel
		: BaseModelIdentity<Int32>
	{
		public ClientModel()
			: base() { }

		private String email;
		private String firstName;
		private String middleName;
		private String lastName;
		private String phone;
		private DateTime dateReg;
		private String company;

		public String Company
		{
			get { return company; }
			set 
			{
				company = value;
				OnPropertyChanged(nameof(Company));
			}
		}
		public DateTime DateReg
		{
			get { return dateReg; }
			set
			{
				dateReg = value;
				OnPropertyChanged(nameof(DateReg));
			}
		}
		public String Phone
		{
			get { return phone; }
			set
			{
				phone = value;
				OnPropertyChanged(nameof(Phone));
			}
		}
		public String LastName
		{
			get { return lastName; }
			set
			{
				lastName = value;
				OnPropertyChanged(nameof(LastName));
			}
		}
		public String MiddleName
		{
			get { return middleName; }
			set
			{
				middleName = value;
				OnPropertyChanged(nameof(MiddleName));
			}
		}
		public String FirstName
		{
			get { return firstName; }
			set
			{
				firstName = value;
				OnPropertyChanged(nameof(FirstName));
			}
		}
		public String Email
		{
			get { return email; }
			set
			{
				email = value;
				OnPropertyChanged(nameof(Email));
			}
		}

		public override bool IsValid { get; } = true;
	}
}