using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Service
{
	interface ISaveDate<T>
	{
		public T Get();
		public void Save(T ob);
		public Boolean Delete(T ob);
	}
}
