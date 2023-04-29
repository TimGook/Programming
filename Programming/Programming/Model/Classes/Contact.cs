using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Contact
    {
        //Строковые поля имя и фамилия
        private string _name;
        private string _surname;

        //Строковое поле Номер телефона
        private string _number;

        //Строковые поля имя и фамилия
        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;

            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                Validator.ValidateNumber(value);
                _number = value;
            }
        }

        //Конструкторы
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public Contact()
        {

        }
        
        private void AssertStringContainsOnlyLetters(string name)
        {
            foreach (char c in name)
            {
                if (!(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z'))
                {
                    throw new ArgumentException("Неверно указано имя");
                }
            }
        }
    }
}