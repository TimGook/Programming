using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersApp.Model.Classes
{
    /// <summary>
    /// Предоставляет доступ к методам валидации значений.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Порверяет, входит ли число <see cref="int"/> в диапазон или нет.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        public static void AssertOnPositiveValue(int value)
        {
            string salary = value.ToString();
            if (value < 0 || value > 500000 || salary[0] == '0' && salary.Length > 1)
            {
                throw new ArgumentException("Значение должно быть положительным и не больше 500000");
            }
        }

        /// <summary>
        /// Порверяет, входит ли число <see cref="double"/> в диапазон или нет.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        public static void AssertOnPositiveValue(double value)
        {
            string salary = value.ToString();
            if (value < 0d || value > 500000d || salary[0] == '0' && salary.Length > 1)
            {
                throw new ArgumentException("Значение должно быть положительным и не больше 500000");
            }
        }

        /// <summary>
        /// Проверяет, состоит ли строка только из буквенный символов.
        /// </summary>
        /// <param name="name"> Проверяемая строка. </param>
        public static void AssertStringContainsOnlyLetters(string name)
        {
            foreach (char c in name)
            {
                if (!(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c == ' ' || c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я' || c == '-'))
                {
                    throw new ArgumentException("Строка должна состоять только из букв.");
                }
            }
        }

        /// <summary>
        /// Метод проверки на дату трудоустройства <see cref="DateTime"/>.
        /// </summary>
        /// <param name="value">проверяемое значение</param>
        /// <returns>True, если дата не более текущего дня, и  False если нет.</returns>
        public static void AssertEmploymentDate(DateTime value)
        {
            if (DateTime.Today < value)
            {
                throw new ArgumentException("Значение введено неверно.");
            }
            
        }
    }
}