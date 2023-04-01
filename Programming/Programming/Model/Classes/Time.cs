using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Time
    {
        private static int MaxHours = 24;
        private static int MaxMinutes = 60;
        private static int MaxSeconds = 60;

        // Часы от 0 до 23
        private int _hours;

        // Минуты от 0 до 59
        private int _minutes;

        //Секунды от 0 до 59
        private int _seconds;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (!Validator.AssertValueInRange(value, 0, MaxHours))
                {
                    throw new Exception("Неправильно введены часы!");
                }
                _hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (!Validator.AssertValueInRange(value, 0, MaxMinutes))
                {
                    throw new Exception("Неправильно введены минуты!");
                }
                _minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (!Validator.AssertValueInRange(value, 0, MaxSeconds))
                {
                    throw new Exception("Неправильно введены секунды!");
                }
                _seconds = value;
            }
        }

        //Конструкторы. Перегрузка в зависимости от введённых данных

        public Time(int seconds, int minutes, int hours)
        {
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        public Time()
        {

        }
    }
}
