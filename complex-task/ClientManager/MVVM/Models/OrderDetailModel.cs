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

        public OrderDetailModel()
            : base() { }

        public override Boolean IsValid { get; } = true;
    }
}
