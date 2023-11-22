using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий заказ покупателя.
    /// </summary>
    class Order
    {
        /// <summary>
        /// Целочисленный уникальный идентификатор.
        /// </summary>
        private int _id;

        /// <summary>
        /// Поле даты заказа.
        /// </summary>
        private string _date;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Счетчик заказов.
        /// </summary>
        private static int _allOrdersCount = 0;

        /// <summary>
        /// Общая стоимость товаров.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает значение уникального идентификатора.
        /// </summary>
        public int Id
        {
            get { return _id; }
            private set
            {
                _id = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт размер примерной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт дату заказа.
        /// </summary>
        public string Date
        {
            get
            {
                return _date;
            }
            private set
            {
                _date = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки.
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
        /// Возвращает счетчик заказов покупателей.
        /// </summary>
        public int AllOrdersCount
        {
            get => _allOrdersCount;
            private set => _allOrdersCount = value;
        }

        /// <summary>
        /// Возвращает и задает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get => _amount;
            set => _amount = value;
        }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address"> Адрес доставки. </param>
        /// <param name="cart"> Товары корзины. </param>
        /// <param name="orderStatus"> Статус заказа. </param>
        /// <param name="date"> Дата заказа.</param>
        public Order(Address address, Cart cart, OrderStatus orderStatus, string date)
        {
            Date = date;
            Address = address;
            Items = cart.Items;
            Amount = cart.Amount;
            OrderStatus = orderStatus;
            Id = _allOrdersCount;
            AllOrdersCount++;
        }
    }
}
