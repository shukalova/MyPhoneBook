using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyPhonebook.ViewModels
{
    public abstract class BaseViewModel: INotifyPropertyChanged, INotifyPropertyChanging
    {
        private bool _touched = false;
        public bool Touched => _touched;
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        public void MarkAsUntouched()
        {
            _touched = false;
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            _touched = true;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnPropertyChanging([CallerMemberName] string propertyName = "")
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
    }
}
