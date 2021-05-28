using MyPhonebook.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPhonebook.ViewModels
{
    public class ContactCardViewModel: BaseViewModel
    {
        private ContactModel contact;

        public ContactCardViewModel()
        {
            contact = new ContactModel();
        }
        public string FirstName
        {
            get => contact.FirstName;
            set 
            {
                contact.FirstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        public string LastName
        {
            get => contact.LastName;
            set
            {
                contact.LastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string MiddleName
        {
            get => contact.MiddleName;
            set
            {
                contact.MiddleName = value;
                OnPropertyChanged(nameof(MiddleName));
            }
        }

        public decimal MobilePhone
        {
            get => contact.MobilePhone;
            set
            {
                contact.MobilePhone = value;
                OnPropertyChanged(nameof(MobilePhone));
            }
        }
        public decimal HomePhone
        {
            get => contact.HomePhone;
            set
            {
                contact.HomePhone = value;
                OnPropertyChanged(nameof(HomePhone));
            }
        }
        public decimal WorkPhone
        {
            get => contact.WorkPhone;
            set
            {
                contact.WorkPhone = value;
                OnPropertyChanged(nameof(WorkPhone));
            }
        }
        public string HomeAddress
        {
            get => contact.HomeAddress;
            set
            {
                contact.HomeAddress = value;
                OnPropertyChanged(nameof(HomeAddress));
            }
        }
        public string WorkAddress
        {
            get => contact.WorkAddress;
            set
            {
                contact.WorkAddress = value;
                OnPropertyChanged(nameof(WorkAddress));
            }
        }
        public string Note
        {
            get => contact.Note;
            set
            {
                contact.Note = value;
                OnPropertyChanged(nameof(Note));
            }
        }

        public void BuildViewModel(ContactModel model)
        {
            contact = model;
        }

        public ContactModel DataModel => contact;
    }
}
