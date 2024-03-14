using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model;

namespace Contacts.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        private Contact _contact;

        public MainVM()
        {
            _contact = new Contact();
        }

        public string Name 
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Phone
        {
            get
            {
                return _contact.Phone;
            }
            set
            {
                _contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) 
            => PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
    }
}
