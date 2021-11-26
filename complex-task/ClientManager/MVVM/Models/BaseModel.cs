﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClientManager.MVVM.Models
{
    /// <summary>
    /// Модель данных без Identity.
    /// </summary>
    [Serializable]
    public abstract class BaseModel
        : INotifyPropertyChanged
    {
        public BaseModel() { }

        /// <summary>
        /// Указывает, валидна ли модель
        /// </summary>
        public abstract Boolean IsValid { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Обнавляет View по свойству
        /// </summary>
        /// <param name="prop">
        /// Имя обновляемого свойства
        /// </param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
