using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Contacts.Model;
using Contacts.Model.Services;

namespace Contacts.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        private Contact _contact;

        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }

        public MainVM()
        {
            _contact = new Contact();
            SaveCommand = new SaveCommand((param) => SavedContact(param));
            LoadCommand = new LoadCommand((param) => LoadedContact(param));
        }

        private void LoadedContact(object param)
        {
            Contact contact = ContactSerializer.LoadFromFile();
            Name = contact.Name;
            Phone = contact.Phone;
            Email = contact.Email;
            MessageBox.Show($"Контакт {Name} загружен!");
        }

        private void SavedContact(object param)
        {
            ContactSerializer.SaveToFile(new Contact(Name, Phone, Email));
            MessageBox.Show($"Контакт {param} сохранён!");
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

        public Contact GetInfo()
        {
            return new Contact(Name, Phone, Email);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) 
            => PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
    }
}
