using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Discipline
    {
        private static int TotalHoursPerTerm = 1320;

        //Целочисленное поле часы
        private int _hours;

        public string Subject { get; set; }

        public string Mark { get; set; }

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (!Validator.AssertValueInRange(value, 0, TotalHoursPerTerm))
                {
                    throw new ArgumentException("Неправильно указано количестов часов");
                }

                _hours = value;
            }
        }

        //Конструктор
        public Discipline(string subject, string mark, int hours)
        {
            Subject = subject;
            Mark = mark;
            Hours = hours;
        }

        //Конструктор без полей
        public Discipline()
        {

        }
    }
}
