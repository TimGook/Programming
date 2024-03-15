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
    /// <summary>
    /// Предоставляет данные для отображения в интерфейс.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий контакт <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Возвращает команду сохранения.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Возвращает команду загрузки.
        /// </summary>
        public ICommand LoadCommand { get; }

        public MainVM()
        {
            _contact = new Contact();
            SaveCommand = new SaveCommand((param) => SavedContact(param));
            LoadCommand = new LoadCommand((param) => LoadedContact(param));
        }

        /// <summary>
        /// Загружает данные контакта.
        /// </summary>
        /// <param name="param">Имя контакта.</param>
        private void LoadedContact(object param)
        {
            Contact contact = ContactSerializer.LoadFromFile();
            Name = contact.Name;
            Phone = contact.Phone;
            Email = contact.Email;
            MessageBox.Show($"Контакт {Name} загружен!");
        }

        /// <summary>
        /// Сохраняет контакт.
        /// </summary>
        /// <param name="param">Имя контакта.</param>
        private void SavedContact(object param)
        {
            ContactSerializer.SaveToFile(new Contact(Name, Phone, Email));
            MessageBox.Show($"Контакт {param} сохранён!");
        }

        /// <summary>
        /// Задаёт и возвращает имя текущего контакта.
        /// </summary>
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

        /// <summary>
        /// Задаёт и возвращает номер текущего контакта.
        /// </summary>
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

        /// <summary>
        /// Задаёт и возвращает почту текущего контакта.
        /// </summary>
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

        /// <summary>
        /// Событие изменения данных контактаю
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) 
            => PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
    }
}
