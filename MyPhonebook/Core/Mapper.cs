using MyPhonebook.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyPhonebook.Core
{
    public static class Mapper
    {
        public static ObservableCollection<ContactCardViewModel> Map(this IEnumerable<ContactModel> contacts)
        {
            var contactList = new List<ContactCardViewModel>();
            foreach (var contact in contacts)
            {
                var viewModel = new ContactCardViewModel();
                viewModel.BuildViewModel(contact);
                contactList.Add(viewModel);
            }
            return new ObservableCollection<ContactCardViewModel>(contactList);
        }
    }
}
