using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Содержит методы валидации значений.
    /// </summary>
    class ValueValidator
    {
        /// <summary>
        /// Проверяет строку на длину.
        /// </summary>
        /// <param name="value"> Проверяемая строка.</param>
        /// <param name="maxLength"> Максимальная длина строки.</param>
        /// <param name="propertyName"> Название проверяемого поля.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new OverflowException($"{propertyName} должен содержать не более {maxLength} символов.");
            }
        }

        /// <summary>
        /// Проверяет вещественное число на нахождение в диапазоне.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        /// <param name="maxValue"> Максимальное значение.</param>
        /// <param name="maxValue"> Минимальное значение. </param>
        /// <param name="propertyName"> Название проверяемого поля. </param>
        public static void AssertDoubleInRange(double value, double maxValue, double minValue, string propertyName)
        {
            if (value > maxValue || value < minValue)
            {
                throw new ArgumentException($"{propertyName} не может быть меньше {minValue} и больше {maxValue}.");
            }
        }
    }
}
