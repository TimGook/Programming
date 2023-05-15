using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит информацию о времени на часах.
    /// </summary>
    class Time
    {
        /// <summary>
        /// Максимальное количестов часов.
        /// </summary>
        private const int MaxHours = 24;

        /// <summary>
        /// Максимальное количество минут.
        /// </summary>
        private const int MaxMinutes = 60;

        /// <summary>
        /// Максимальное количество секунд.
        /// </summary>
        private const int MaxSeconds = 60;

        /// <summary>
        /// Количестов часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Количестов минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Количестов секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Задаёт и возвращает количество часов. Должно быть больше 0 и меньше 24.
        /// </summary>
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

        /// <summary>
        /// Задаёт и возвращает количество минут. Должно быть больше 0 и меньше 60.
        /// </summary>
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

        /// <summary>
        /// Задаёт и возвращает количество секунд. Должно быть больше 0 и меньше 60.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="seconds"> Количество секунд. Должно быть больше 0 и меньше 60. </param>
        /// <param name="minutes"> Количество минут. Должно быть больше 0 и меньше 60.</param>
        /// <param name="hours"> Количество часов. Должно быть больше 0 и меньше 24.</param>
        public Time(int seconds, int minutes, int hours)
        {
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {

        }
    }
}