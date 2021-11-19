using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.MVVM.Models
{
    internal abstract class BaseModelIdentity<T>
        : BaseModel
    {
        protected BaseModelIdentity()
            : base() { }
    
        public T Identity { get; set; }
    }
}
