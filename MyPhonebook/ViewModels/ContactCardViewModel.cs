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
    }
}
