using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит информацию о заказчике.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Счётчик для <see cref="Id"/>.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Полное имя заказчика.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес заказчика.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает идентификатор.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Задаёт и возвращает полное имя заказчика.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, Fullname);
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес заказчика.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, Address);
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname"> Полное имя заказчика. Должно быть не больше 200 символов. </param>
        /// <param name="address"> Адрес заказчика. Должно содержать не более 500 символов. </param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _idCounter++;
            Id = _idCounter;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _idCounter++;
            Id = _idCounter;
        }
    }
}
