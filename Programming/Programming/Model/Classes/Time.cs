using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Time
    {
        private const int MaxHours = 23;
        private const int MaxMinutes = 59;
        private const int MaxSeconds = 59;

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
                Validator.AssertValueInRange(value, 0, MaxHours);
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
                Validator.AssertValueInRange(value, 0, MaxMinutes);
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
                Validator.AssertValueInRange(value, 0, MaxSeconds);
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