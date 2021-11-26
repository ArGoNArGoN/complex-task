using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.MVVM.Models
{
    [Serializable]
    internal class OrderModel
        : BaseModelIdentity<Int32>
    {
        private String descroption;
        private String annotation;
        private DateTime date;

        private DateTime lastModifeidDate;
        private Decimal coust;

        private StatusOrderModel statusOrder;
        private ClientModel client;
        private EmployeeModel clientEmployee;
        
        private Int32 idClient;
        private Int32 idEmployee;
        private Int32 idStatusOrder;

        public OrderModel()
            : base() { }

        public String Descroption
        {
            get { return descroption; }
            set 
            { 
                descroption = value;
                OnPropertyChanged(nameof(Descroption));
            }
        }
        public String Annotation
        {
            get { return annotation; }
            set
            {
                annotation = value;
                OnPropertyChanged(nameof(Annotation));
            }
        }
        public DateTime Date
        {
            get { return date; }
            set 
            {
                date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        public Decimal Coust
        {
            get { return coust; }
            set 
            {
                coust = value;
                OnPropertyChanged(nameof(Coust));
            }
        }
        public DateTime LastModifiedDate
        {
            get { return lastModifeidDate; }
            set
            {
                lastModifeidDate = value;
                OnPropertyChanged(nameof(LastModifiedDate));
            }
        }

        public StatusOrderModel StatusOrder
        {
            get { return statusOrder; }
            set 
            {
                statusOrder = value;
                OnPropertyChanged(nameof(StatusOrder));
            }
        }
        public ClientModel Client
        {
            get { return client; }
            set
            {
                client = value;
                OnPropertyChanged(nameof(Client));
            }
        }
        public EmployeeModel ClientEmployee
        {
            get { return clientEmployee; }
            set
            {
                clientEmployee = value;
                OnPropertyChanged(nameof(ClientEmployee));
            }
        }

        public Int32 IdStatusOrder
        {
            get { return idStatusOrder; }
            set { idStatusOrder = value; }
        }
        public Int32 IdEmployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }
        public Int32 IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        public override Boolean IsValid { get; } = true;
    }
}
