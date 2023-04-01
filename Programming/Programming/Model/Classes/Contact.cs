using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Contact
    {
        //Строковое поле Номер телефона
        private string _number;

        //Строковые поля имя и фамилия
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Number
        {
            get => _number;
            set
            {
                if (!Validator.ValidateNumber(value))
                {
                    throw new ArgumentException("Неверно введён номер телефона");
                }
                _number = value;
            }
        }

        //Конструкторы
        public Contact(string name, string surname, string number, string organization)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        public Contact()
        {

        }
    }
}
