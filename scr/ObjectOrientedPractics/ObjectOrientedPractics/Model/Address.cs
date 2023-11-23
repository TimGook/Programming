using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        /// <summary>
        /// Почтовый индекс, целое шестизначное число.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион, строка, не более 50 символов.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт), строка, не более 50 символов.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица, строка, не более 100 символов.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома, строка, не более 10 символов.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения, не более 10 символов.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс. Шестизначное число.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertIntInRange(value, 999999, 100000, "Неверное значение почтового индекса. Шестизначное число.");
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт страну/регион. Не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 50, "Неверное значение страны/региона. Не более 50 символов.");
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт город. Не более 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0,  50, "Неверное значение города. Не более 50 символов.");
                _city = value;

            }
        }

        /// <summary>
        /// Возвращает и задаёт улицу. Не более 100 символов
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 100, "Неверное значение улицы. Не более 100 символов.");
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома. Не более 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 10, "Неверное значение номера дома. Не более 10 символов.");
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения. Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 10, "Неверное значение страны/региона. Не более 10 символов.");
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна/регион.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер здания.</param>
        /// <param name="apartment">Номер квартиры/помещения.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Address"/>.
        /// </summary>
        /// <returns>Строка: Index, Country, City, Street, Building, Apartment.</returns>
        public override string ToString()
        {
            return $"Index: {Index}, Country:{Country}, City:{City}, Street:{Street}, Building:{Building}, Apartment:{Apartment}";
        }

        /// <summary>
        /// Клонирование объекта класса.
        /// </summary>
        /// <returns>Клонированный объект класса <see cref="Item"/>.</returns>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// <inheritdoc cref="IEquatable<Address>"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="Address"/>.</param>
        /// <returns>True - если они равны. False - не равны.</returns>
        public bool Equals(Address other)
        {
            if (other == null)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            if (this.Index == other.Index || this.Building == other.Building
                || this.City == other.City || this.Country == other.Country
                || this.Street == other.Street || this.Apartment == other.Apartment)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
