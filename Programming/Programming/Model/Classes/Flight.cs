using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит информацию о рейсе.
    /// </summary>
    class Flight
    {
        /// <summary>
        /// Максимальное время полёта в минутах.
        /// </summary>
        private const int MaxFlightTimeInMinutes = 4000;

        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Пункт вылета.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Пункт назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Задаёт и возвращает время полёта в минутах. Должно быть больше 0 и меньше 4000.
        /// </summary>
        public int FightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, MaxFlightTimeInMinutes);
                _flightTime = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure"> Пункт вылета. </param>
        /// <param name="destination"> Пункт назначения. </param>
        /// <param name="flightTime"> Время полёта в минутах. </param>
        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FightTime = flightTime;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {

        }
    }
}