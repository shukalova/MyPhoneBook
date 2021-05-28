using System;
using System.Collections.Generic;
using System.Text;

namespace MyPhonebook.ViewModels
{
    public class PhonebookViewModel: BaseViewModel
    {
        private ContactCardViewModel _selectedCard;
        private string _test;

        public string Test { get => _test; set { _test = value; OnPropertyChanged(nameof(Test)); } }
        public ContactCardViewModel SelectedCard
        {
            get => _selectedCard;
            set
            {
                _selectedCard = value;
                OnPropertyChanged(nameof(SelectedCard));
            }
        } 
    }
}
