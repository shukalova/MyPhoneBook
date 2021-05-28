using System;
using System.Collections.Generic;
using System.Text;

namespace MyPhonebook.Core
{
    public class ContactRepository
    {
        public void Add(ContactModel contact)
        {
            using (var context = new MyPhoneDbContext())
            {
                context.MyPhonebook.Add(contact);
                context.SaveChanges();
            }
        }

        public IEnumerable<ContactModel> GetAll()
        {
            var context = new MyPhoneDbContext();
            return context.MyPhonebook;
        }
    }
}
