using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// так как в бд нет и не будет составных ключей, Identity один
/// </summary>
namespace ClientManager.MVVM.Models
{
    /// <summary>
    /// Базовый класс для модели
    /// </summary>
    /// <typeparam name="T">
    /// Тип ключа
    /// </typeparam>
    [Serializable]
    internal abstract class BaseModelIdentity<T>
        : BaseModel
    {
        protected BaseModelIdentity()
            : base() { }
    
        /// <summary>
        /// Первичный ключ
        /// </summary>
        public T Identity { get; set; }
    }
}
