using System;
using System.Collections.Generic;
using System.Text;

namespace MyPhonebook.Core
{
    public class ContactModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public decimal MobilePhone { get; set; }
        public decimal HomePhone { get; set; }
        public decimal WorkPhone { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public string Note { get; set; }
    }
}
