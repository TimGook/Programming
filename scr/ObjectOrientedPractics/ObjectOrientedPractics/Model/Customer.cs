using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит информацию о заказчике.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Счётчик для <see cref="Customer"/>.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Полное имя заказчика.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес заказчика.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart = new Cart();

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Возвращает идентификатор.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Задаёт и возвращает список скидок.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Является ли заказчик приоритетным в обслуживании.
        /// </summary>
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Задаёт и возвращает список заказов.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт корзину товара <see cref="Cart"/>.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }

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
                ValueValidator.AssertStringOnLength(value, 0, 200, Fullname);
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адресс доставки.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname"> Полное имя заказчика. Должно быть не больше 200 символов. </param>
        /// <param name="address"> Адрес заказчика типа <see cref="Address">. </param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            _idCounter++;
            Id = _idCounter;
            Cart = new Cart();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            Cart = new Cart();
            _idCounter++;
            Id = _idCounter;
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Customer"/>.
        /// </summary>
        /// <returns>Строка: id, Fullname, adress.</returns>
        public override string ToString()
        {
            return $"Id: {Id}, Fullname: {Fullname}, Address: {Address}";
        }

        /// <summary>
        /// Клонирование объекта класса для редактирования его через текстовые поля.
        /// </summary>
        /// <returns>Клонированный объект класса.</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
