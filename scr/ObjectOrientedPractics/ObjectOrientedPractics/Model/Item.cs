using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит информацию о товаре.
    /// </summary>
    class Item: ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Счётчик для <see cref="Id"/>.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category = new Category();

        /// <summary>
        /// Возвращает идентификатор.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возврашает и задаёт название товара. Не может быть больше 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание товара. Не может быть больше 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара. Не может быть больше 100 000 и меньше 0.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertDoubleInRange(value, 100_000.0, 0.0, "Cost");
                _cost = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name"> Название товара. Не может быть больше 200 символов. </param>
        /// <param name="category"> Категория товара типа <see cref="Category">. </param>
        /// <param name="info"> Описание товара. Не может быть больше 1000 символов. </param>
        /// <param name="cost"> Стоимость товара. Не можеть быть больше 100 000 и меньше 0. </param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            _idCounter++;
            Id = _idCounter;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _idCounter++;
            Id = _idCounter;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Item"/>.
        /// </summary>
        /// <returns>Строка: id, cost, name, info.</returns>
        public override string ToString()
        {
            return $"Id: {Id}, Cost: {Cost}, Name: {Name}, Info: {Info}";
        }

        /// <summary>
        /// Клонирование объекта класса для редактирования его через текстовые поля.
        /// </summary>
        /// <returns>Клонированный объект класса.</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        ///// <summary>
        ///// Клонирование объекта класса для редактирования его через текстовые поля.
        ///// </summary>
        ///// <returns>Клонированный объект класса <see cref="Item"/>.</returns>
        //public object Clone()
        //{
        //    return new Item(Name, Info, Cost, Category);
        //}

        /// <summary>
        /// <inheritdoc cref="IEquatable<Address>"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="Item"/>.</param>
        /// <returns>True - если они равны. False - не равны.</returns>
        public bool Equals(Item other)
        {
            if (other == null)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            if (this.Name == other.Name || this.Info == other.Info
                || this.Cost == other.Cost || this.Category == other.Category)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// <inheritdoc cref="IComparable"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="Item"/>.</param>
        /// <returns>1 - больше или null сравниваемый объект. 0 - они равны. -1 - сравниваемый больше.</returns>
        public int CompareTo(Item other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.Cost.CompareTo(other.Cost);
            }
        }
    }
}
