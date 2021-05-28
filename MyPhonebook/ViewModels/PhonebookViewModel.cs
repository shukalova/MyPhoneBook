using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyPhonebook.ViewModels
{
    public class PhonebookViewModel: BaseViewModel
    {
        private ObservableCollection<ContactCardViewModel> _cardList;
        private ContactCardViewModel _selectedCard;
        private string _test;

        public PhonebookViewModel()
        {
            _selectedCard = new ContactCardViewModel();
            _cardList = new ObservableCollection<ContactCardViewModel>()
            {
                new ContactCardViewModel
                {
                    FirstName = "Anna",
                    LastName = "Shukalova"
                },
                new ContactCardViewModel
                {
                    FirstName = "Masha",
                    LastName = "Kulakova"
                },
                new ContactCardViewModel
                {
                    FirstName = "Sasha",
                    LastName = "Ruchnikova"
                }
            };
        }

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

        public ObservableCollection<ContactCardViewModel> CardList
        {
            get => _cardList;
            set
            {
                _cardList = value;
                OnPropertyChanged(nameof(CardList));
            }
        }
    }
}
