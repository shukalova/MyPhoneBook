using System;
using System.Collections.Generic;
using System.Text;

namespace MyPhonebook.ViewModels
{
    public class ContactCardViewModel: BaseViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private string _mobilePhone;
        private string _homePhone;
        private string _workPhone;
        private string _homeAddress;
        private string _workAddress;
        private string _note;

        public string FirstName
        {
            get => _firstName;
            set 
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string MiddleName
        {
            get => _middleName;
            set
            {
                _middleName = value;
                OnPropertyChanged(nameof(MiddleName));
            }
        }

        public string MobilePhone
        {
            get => _mobilePhone;
            set
            {
                _mobilePhone = value;
                OnPropertyChanged(nameof(MobilePhone));
            }
        }
        public string HomePhone
        {
            get => _homePhone;
            set
            {
                _homePhone = value;
                OnPropertyChanged(nameof(HomePhone));
            }
        }
        public string WorkPhone
        {
            get => _workPhone;
            set
            {
                _workPhone = value;
                OnPropertyChanged(nameof(WorkPhone));
            }
        }
        public string HomeAddress
        {
            get => _homeAddress;
            set
            {
                _homeAddress = value;
                OnPropertyChanged(nameof(HomeAddress));
            }
        }
        public string WorkAddress
        {
            get => _workAddress;
            set
            {
                _workAddress = value;
                OnPropertyChanged(nameof(WorkAddress));
            }
        }
        public string Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }
    }
}
