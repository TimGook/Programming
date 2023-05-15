using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит данные об учебной дисциплине.
    /// </summary>
    class Discipline
    {
        /// <summary>
        /// Максимальное количество часов у дисциплины.
        /// </summary>
        private const int TotalHoursPerTerm = 1320;

        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Оценка за дисципоину.
        /// </summary>
        private string _mark;

        /// <summary>
        /// Задаёт и возвращает название дисциплины.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Задаёт и возвращает оценку за дисциплину. Должна быть строкой, содержащей, "2", "3", "4", "5", "зачёт" или "незачёт".
        /// </summary>
        public string Mark
        {
            get
            {
                return _mark;
            } 
            set
            {
                if (Validator.ValidateMark(value))
                {
                    _mark = value;
                }
            }      
        }

        /// <summary>
        /// Задаёт и возвращает колическто часов. Должно быть больше 0 и меньше 1320.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, TotalHoursPerTerm);
                _hours = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="subject"> Назвалине писциплины. </param>
        /// <param name="mark"> Оценка за дисциплину. Должна быть строкой, содержащей, "2", "3", "4", "5", "зачёт" или "незачёт". </param>
        /// <param name="hours"></param>
        public Discipline(string subject, string mark, int hours)
        {
            Subject = subject;
            Mark = mark;
            Hours = hours;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline()
        {

        }
    }
}
