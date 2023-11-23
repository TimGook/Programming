using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Содержит информацию для скидки.
    /// </summary>
    class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Количество баллов.
        /// </summary>
        private int _pointsCounter = 0;

        /// <summary>
        /// Задаёт и возвращает количество баллов.
        /// </summary>
        public int PointsCounter
        {
            get
            {
                return _pointsCounter;
            }
            private set
            {
                ValueValidator.AssertIntInRange(value, int.MaxValue, 0, "PointsCounter");
                _pointsCounter = value;
            }
        }

        /// <summary>
        /// Метод, который возвращает размер скидки, доступный для данного скиска продуктов с текущим количеством баллов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns></returns>
        public double Calculate(List<Item> items)
        {
            double amount = items.Sum(item => item.Cost);
            double amountWithDiscount;
            double amountDiscount = 0;

            if (PointsCounter > amount * 0.3)
            {
                amountWithDiscount = amount * 0.7;
                amountDiscount = amountWithDiscount;
            }
            else
            {
                amountWithDiscount = amount - PointsCounter;
                amountDiscount = amount - amountWithDiscount;
            }

            return Convert.ToInt32(amountDiscount);
        }

        /// <summary>
        /// Метод, который применяет скидку к товарам.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public double Apply(List<Item> items)
        {
            int amount = Convert.ToInt32(Calculate(items));
            PointsCounter -= amount;
            Update(items);
            return amount;
        }

        /// <summary>
        /// Метод, который добавляет баллы на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double amount = items.Sum(item => item.Cost);

            PointsCounter += Convert.ToInt32(Math.Ceiling(amount * 0.1));
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get => $"«Накопительная – {PointsCounter} баллов";
        }

        /// <summary>
        /// <inheritdoc cref="IComparable"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="PointsDiscount"/>.</param>
        /// <returns>1 - больше или null сравниваемый объект. 0 - они равны. -1 - сравниваемый больше.</returns>
        public int CompareTo(PointsDiscount other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return this.PointsCounter.CompareTo(other.PointsCounter);
            }
        }
    }
}
