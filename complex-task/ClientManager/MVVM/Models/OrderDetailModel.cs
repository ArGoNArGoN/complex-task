using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.MVVM.Models
{
    internal class OrderDetailModel
        : BaseModelIdentity<Int32>
    {
        private String annotation;
        private String resourse;
        private String onPropertyTable;
        private DateTime lastModifiedDate;
        private Int32 idOrder;
        private Int32 idProduct;
        private Int32 idStatusDatail;

        private Product product;
        private StatusDatail statusDatail;

        public String Anatation
        {
            get { return annotation; }
            set
            {
                annotation = value;
                OnPropertyChanged(nameof(Anatation));
            }
        }
        public String Resourse
        {
            get { return resourse; }
            set
            {
                resourse = value;
                OnPropertyChanged(nameof(Resourse));
            }
        }
        public String OnPropertyTable
        {
            get { return onPropertyTable; }
            set
            {
                onPropertyTable = value;
                OnPropertyChanged(nameof(OnPropertyTable));
            }
        }
        public DateTime LastModifiedDate
        {
            get { return lastModifiedDate; }
            set
            {
                lastModifiedDate = value;
                OnPropertyChanged(nameof(LastModifiedDate));
            }
        }
        public Int32 IdOrder
        {
            get { return idOrder; }
            set
            {
                idOrder = value;
                OnPropertyChanged(nameof(IdOrder));
            }
        }
        public Int32 IdProduct
        {
            get { return idProduct; }
            set
            {
                idProduct = value;
                OnPropertyChanged(nameof(IdProduct));
            }
        }
        public Int32 IdStatusDatail
        {
            get { return idStatusDatail; }
            set
            {
                idStatusDatail = value;
                OnPropertyChanged(nameof(IdStatusDatail));
            }
        }

        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                OnPropertyChanged(nameof(Product));
            }
        }
        public StatusDatail StatusDatail
        {
            get { return statusDatail; }
            set
            {
                statusDatail = value;
                OnPropertyChanged(nameof(StatusDatail));
            }
        }

        public OrderDetailModel()
            : base() {  }

        public override Boolean IsValid { get; } = true;
    }
}
