using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyPhonebook.ViewModels
{
    public abstract class BaseViewModel: INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void OnPropertyChanging([CallerMemberName] string propertyName = "") =>
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
    }
}
