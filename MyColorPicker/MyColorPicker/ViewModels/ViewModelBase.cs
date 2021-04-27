using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel; //nedded to create a fire a property changed event
using System.Runtime.CompilerServices;

namespace MyClock.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            //? checks is PropertyChanged is null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //if (PropertyChanged != null)
            //{
            //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //}
        }
    }
}
