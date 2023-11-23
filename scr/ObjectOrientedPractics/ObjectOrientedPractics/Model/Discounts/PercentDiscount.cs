using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Текущая категория товара.
        /// </summary>
        public Category DiscountCategory;

        /// <summary>
        /// Текущая стоимость товаров.
        /// </summary>
        private double _amount = 0;

        /// <summary>
        /// Текущее значение скидки.
        /// </summary>
        private double _currentDiscount = 0.01;

        /// <summary>
        ///Возвращает и задаёт текущее значение скикди. Не более 0.1 (10%).
        /// </summary>
        private double CurrentDiscount
        {
            get => _currentDiscount;
            set
            {
                if (value > 0.1)
                {
                    _currentDiscount = 0.1;
                }
                else
                    _currentDiscount = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт текущую стоимость товаров.
        /// </summary>
        private double Amount
        {
            get => _amount;
            set
            {
                ValueValidator.AssertDoubleInRange(value, double.MaxValue, 0, "Amount");
                if (value/1000 >= 1d)
                {
                    CurrentDiscount += (value / 1000)/100d;
                }
                _amount = value;
            }
        }

        /// <summary>
        /// Метод, который обновляет накопительную скидку 
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == DiscountCategory)
                {
                    amount += items[i].Cost;
                }
            }

            return amount * CurrentDiscount;
        }

        /// <summary>
        /// Метод применяющий скидку для товаров заданной категории.
        /// </summary>
        /// <param name="items"><Список товаров./param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Update(items);
            return discount;
        }

        /// <summary>
        /// Метод, который обновляет накопительную скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == DiscountCategory)
                {
                    Amount += items[i].Cost;
                }
            }
        }

        /// <summary>
        /// Возвращает информацию о скидки.
        /// </summary>
        public string Info
        {
            get => $"«Процентная «{DiscountCategory}» - {_currentDiscount * 100}%";
        }

        /// <summary>
        /// <inheritdoc cref="IComparable"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="PercentDiscount"/>.</param>
        /// <returns>1 - больше или null сравниваемый объект. 0 - они равны. -1 - сравниваемый больше.</returns>
        public int CompareTo(PercentDiscount other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.CurrentDiscount.CompareTo(other.CurrentDiscount);
            }
        }
    }
}