using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет доступ к методам валидации.
    /// </summary>
    class Validator
    {
        /// <summary>
        /// Проверяет, соответствует стока ли написанию номеров телефона или нет.
        /// </summary>
        /// <param name="number"> Проверяемая строка. </param>
        /// <returns> True, если строка соответсвует написанию номеров телефона, false, если строка не соответсвует написанию номеров телефона. </returns>
        public static bool ValidateNumber(string number)
        {
            string Numbers = "0123456789";
            bool NumberIsDigit = true;
            
            if (number[0] == '+')
            {
                for (int i = 1; i < number.Length; i++)
                {
                    if (!Numbers.Contains(number[i]))
                    {
                        NumberIsDigit = false;
                        break;
                    }
                }
            }
            else
            {
                foreach (char d in number)
                {
                    if (!Numbers.Contains(d))
                    {
                        NumberIsDigit = false;
                        break;                        
                    }
                }
            }
            
            return (number.Length == 11 || number.Length == 12) && number[0] == '+' && NumberIsDigit;
        }

        /// <summary>
        /// Порверяет, является число <see cref="Int32"/> положительным или нет.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        public static void AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Значение должно быть положительным");
            }
        }

        /// <summary>
        /// Порверяет, является число <see cref="Double"/> положительным или нет.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        public static void AssertOnPositiveValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Значение должно быть положительным");
            }
        }

        /// <summary>
        /// Проверяет, входит ли число <see cref="Int32"/> в диапазон или нет.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        /// <param name="min"> Минимальное значение. </param>
        /// <param name="max"> Максимальное значение. </param>
        public static void AssertValueInRange(int value, int min, int max)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException("Число не входит в заданный диапазон.");
            }
        }

        /// <summary>
        /// Проверяет, входит ли число <see cref="Double"/> в диапазон или нет.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        /// <param name="min"> Минимальное значение. </param>
        /// <param name="max"> Максимальное значение. </param>
        public static void AssertValueInRange(double value, double min, double max)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException("Число не входит в заданный диапазон.");
            }
        }

        /// <summary>
        /// Проверяет, явлиется ли строка оценкой за дисциплину.
        /// </summary>
        /// <param name="mark"> Проверяемая строка. </param>
        /// <returns> True, если строка является оценкой, и false, если строка не явлияется оценкой. </returns>
        public static bool ValidateMark(string mark)
        {
            string[] marks = { "2", "3", "4", "5", "незачёт", "зачёт" };
            bool MarkIsCorrect = false;
            foreach (string Mark in marks)
            {
                if (!(Mark == mark))
                {
                    MarkIsCorrect = true;
                    break;
                }
            }

            return MarkIsCorrect;
        }

        /// <summary>
        /// Проверяет, состоит ли строка только из буквенный символов.
        /// </summary>
        /// <param name="name"> Проверяемая строка. </param>
        public static void AssertStringContainsOnlyLetters(string name)
        {
            foreach (char c in name)
            {
                if (!(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z'))
                {
                    throw new ArgumentException("Неверно указано имя");
                }
            }
        }
    }
}