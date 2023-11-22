using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.DopMission4
{
    /// <summary>
    /// Содержит информацию о человеке.
    /// </summary>
    class Person
    {
        /// <summary>
        /// Имя.
        /// </summary>
        protected string _firstName;

        /// <summary>
        /// Фамилия.
        /// </summary>
        protected string _lastName;

        /// <summary>
        /// Возраст.
        /// </summary>
        protected int _age;

        /// <summary>
        /// Задаёт и возвращает имя.
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает фамилию.
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает возраст. Не можеть быть отрицательным.
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Возраст не может быть отрицательным!");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр человека.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
