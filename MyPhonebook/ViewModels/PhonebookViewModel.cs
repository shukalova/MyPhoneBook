using MyPhonebook.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace MyPhonebook.ViewModels
{
    public class PhonebookViewModel : BaseViewModel
    {
        private ObservableCollection<ContactCardViewModel> _cardList;
        private ContactCardViewModel _selectedCard;
        private ContactRepository repository = new ContactRepository();
        private static int tempIndex = 0;
        private static decimal tempPhone = 3800000000;
        private IEnumerable<ContactModel> _source;

        private RelayCommand _addContact;
        private RelayCommand _deleteContact;
        private RelayCommand _saveContact;
        public RelayCommand AddContact
        {
            get
            {
                return _addContact ??
                  (_addContact = new RelayCommand(obj =>
                  {
                      var index = tempIndex++;
                      CardList.Add(new ContactCardViewModel()
                      {
                          FirstName = $"New Contact {index}",
                          LastName = $"New Contact {index}",
                          MobilePhone = tempPhone++
                      });
                  }));
            }
        }
        public RelayCommand DeleteContact
        {
            get
            {
                return _deleteContact ??
                  (_deleteContact = new RelayCommand(obj =>
                  {
                      var answer = MessageBox.Show("Are you sure that you wanna delete it?", "Warning", MessageBoxButton.YesNo);
                      if (answer == MessageBoxResult.Yes)
                      {
                          repository.Delete(SelectedCard.DataModel);
                          _cardList.Remove(SelectedCard);
                      }
                  }));
            }
        }
        public RelayCommand SaveContact
        {
            get
            {
                return _saveContact ??
                  (_saveContact = new RelayCommand(obj =>
                  {
                      var contactsToUpdateVM = _cardList
                      .Where(x => x.Touched);

                      if (contactsToUpdateVM.Count() > 0)
                      {
                          var contactsToUpdate = contactsToUpdateVM
                          .Select(x => x.DataModel);
                          repository.Update(contactsToUpdate);
                          foreach (var item in contactsToUpdateVM)
                          {
                              item.MarkAsUntouched();
                          }
                      }
                  }));
            }
        }

        public PhonebookViewModel()
        {
            _source = new ContactRepository().GetAll();
            _cardList = _source.Map();
        }

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

        public void Search(string value)
        {
            if (value?.Length > 0)
            {
                CardList = _source
                    .Where(x =>
                        x.FirstName.ToLower().Contains(value.ToLower()) ||
                        x.LastName.ToLower().Contains(value.ToLower()) ||
                        x.MobilePhone.ToString().Contains(value)
                     )
                    .Map();
            } else
            {
                CardList = _source.Map();
            }
        }
    }
}

