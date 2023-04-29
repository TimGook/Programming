using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Flight
    {
        private const int MaxFlightTimeInMinutes = 4000;

        // Целочисленное поле времени полёта
        private int _flightTime;

        // Автосвойство поле Пункт вылета
        public string Departure { get; set; }

        // Автосвойство поле Пункт назначения
        public string Destination { get; set; }

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

        //Конструкторы
        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FightTime = flightTime;
        }

        public Flight()
        {

        }
    }
}