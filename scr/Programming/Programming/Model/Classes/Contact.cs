using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит информацию о контакте.
    /// </summary>
    class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _number;

        /// <summary>
        /// Задаёт и возращает имя. Должно содержать только буквы.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Validator.AssertStringContainsOnlyLetters(value);
                _name = value;

            }
        }

        /// <summary>
        /// Задаёт и возращает фамилию. Должна содержать только буквы.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                Validator.AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает номер телефона. Должен содержать либо 11 цифр, либо символ + и 11 цифр без пробела.
        /// </summary>
        public string Number
        {
            get => _number;
            set
            {
                Validator.ValidateNumber(value);
                _number = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name"> Имя. Должно содержать только буквы. </param>
        /// <param name="surname"> Фамилия. Должна содержать только буквы.</param>
        /// <param name="number"></param>
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Создёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        } 
    }
}