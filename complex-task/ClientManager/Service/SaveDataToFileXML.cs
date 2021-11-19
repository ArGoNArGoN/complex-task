using System;

namespace ClientManager.Service
{
    public abstract class SaveDataToFileXML<T>
        : ISaveData<T>
    {
        protected String nameFile;

        protected const String FileExtension = ".xml";

        public String NameFile
        {
            get { return nameFile; }
            set { nameFile = value?.Trim() ?? "NewFile"; }
        }

        public abstract void DeleteData(T ob);
        public abstract T GetData();
        public abstract void SaveData(T ob);
    }
}
