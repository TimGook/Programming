using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Validator
    {
        //Статический метода проверки на правильность ввода номера
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

        //Статический метод проверки на положительность числа (int32)
        public static void AssertOnPositiveValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Значение должно быть положительным");
            }
        }
        
        //Статический метод проверки на положительность числа (double)
        public static void AssertOnPositiveValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Значение должно быть положительным");
            }
        }
        
        //Статический метод проверки на дапазон
        public static void AssertValueInRange(int value, int min, int max)
        {
            if ((value <= min) || (value >= max))
            {
                throw new ArgumentException("Число не входит в заданный диапазон.");
            }
        }

        //Статический метод проверки на дапазон
        public static void AssertValueInRange(double value, double min, double max)
        {
            if ((value <= min) || (value >= max))
            {
                throw new ArgumentException("Число не входит в заданный диапазон.");
            }
        }

        //Статический метод проверки на правильность ввода оценки
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
    }
}