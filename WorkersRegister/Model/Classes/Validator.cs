using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersRegister.Classes
{
    /// <summary>
    /// Предоставляет доступ к методам валидации значений.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Порверяет, входит ли число <see cref="Int32"/> в диапазон или нет.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        public static bool CheckOnPositiveValue(int value)
        {
            bool ValueIsPositive = true;
            if (value < 0 || value > 500000)
            {
                ValueIsPositive = false;
            }

            return ValueIsPositive;
        }

        /// <summary>
        /// Порверяет, входит ли число <see cref="Double"/> в диапазон или нет.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        public static bool CheckOnPositiveValue(double value)
        {
            bool ValueIsPositive = true;
            if (value < 0d || value > 500000d)
            {
                ValueIsPositive = false;
            }

            return ValueIsPositive;
        }

        /// <summary>
        /// Проверяет, состоит ли строка только из буквенный символов.
        /// </summary>
        /// <param name="name"> Проверяемая строка. </param>
        public static bool CheckStringContainsOnlyLetters(string name)
        {
            bool StringContainsOnlyLetters = true;
            foreach (char c in name)
            {
                if (!(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c == ' '))
                {
                    StringContainsOnlyLetters = false;
                }
            }
            return StringContainsOnlyLetters;
        }

        /// <summary>
        /// Метод проверки на дату трудоустройства <see cref="DateTime"/>.
        /// </summary>
        /// <param name="value">проверяемое значение</param>
        /// <returns>True, если дата не более текущего дня, и  False если нет.</returns>
        public static bool CheckEmploymentDate(DateTime value)
        {
            return (DateTime.Today <= value);
        }
    }
}