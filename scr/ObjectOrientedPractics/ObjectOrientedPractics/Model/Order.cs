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
        protected int _id;

        /// <summary>
        /// Поле даты заказа.
        /// </summary>
        protected string _date;

        /// <summary>
        /// Список товаров.
        /// </summary>
        protected List<Item> _items;

        /// <summary>
        /// Счетчик заказов.
        /// </summary>
        protected static int _allOrdersCount = 0;

        /// <summary>
        /// Общая стоимость товаров.
        /// </summary>
        protected double _amount;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        protected Address _address = new Address();

        /// <summary>
        /// Возвращает значение уникального идентификатора.
        /// </summary>
        public int Id
        {
            get { return _id; }
            protected set
            {
                _id = value;
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
        /// Возвращает дату заказа.
        /// </summary>
        public string Date
        {
            get
            {
                return _date;
            }
            protected set
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
            protected set => _allOrdersCount = value;
        }

        /// <summary>
        /// Возвращает и задает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                {
                    return 0.0;
                }
                return Items.Sum(item => item.Cost);
            }
            // TODO: удалить сеттер.
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
