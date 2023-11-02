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
        /// <param name="minLength"> Максимальная длина строки.</param>
        /// <param name="maxLength"> Максимальная длина строки.</param>
        /// <param name="propertyName"> Название проверяемого поля.</param>
        public static void AssertStringOnLength(string value, int minLength, int maxLength, string propertyName)
        {
            try
            {
                if (value.Length > maxLength || value.Length < minLength)
                {
                    throw new OverflowException($"{propertyName} должен содержать не менее {minLength} и не более {maxLength} символов.");
                }
            }
            catch (ArgumentNullException)
            {
                value = "";
            }
            catch (System.NullReferenceException)
            {
                value = "";
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

        /// <summary>
        /// Проверяет вещественное число на нахождение в диапазоне.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        /// <param name="maxValue"> Максимальное значение.</param>
        /// <param name="maxValue"> Минимальное значение. </param>
        /// <param name="propertyName"> Название проверяемого поля. </param>
        public static void AssertIntInRange(int value, int maxValue, int minValue, string propertyName)
        {
            if (value > maxValue || value < minValue)
            {
                throw new ArgumentException($"{propertyName} не может быть меньше {minValue} и больше {maxValue}.");
            }
        }
    }
}
