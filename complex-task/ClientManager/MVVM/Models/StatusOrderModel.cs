using System;

namespace ClientManager.MVVM.Models
{
	[Serializable]
	internal class StatusOrderModel
		: BaseModelIdentity<Int32>
	{
		public StatusOrderModel()
			: base() { }

		public Int32 Number { get; set; }
		public String Title { get; set; }

		public override Boolean IsValid { get; } = true;
	}
}