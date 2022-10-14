using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp_Navigation.Models
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {

        protected void OnChanged<T>(out T prop, T value, [CallerMemberName] string propName = "")
        {

            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
