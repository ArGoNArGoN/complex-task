using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Service
{
    public interface ISaveData<T>
    {
        void SaveData(T ob);
        void DeleteData(T ob);

        T GetData();
    }
}
