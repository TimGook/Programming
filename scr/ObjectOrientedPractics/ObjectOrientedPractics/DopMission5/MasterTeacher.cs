using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.DopMission5
{
    /// <summary>
    /// Класс, описывающий доцента.
    /// </summary>
    class MasterTeacher :Stuff
    {
        /// <summary>
        /// Зарплата.
        /// </summary>
        private double _salary;

        /// <summary>
        /// Задаёт зарплату.
        /// </summary>
        /// <param name="value">Зарплата.</param>
        public void SetSalary(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Зарплата не может быть меньше 0!");
            }
            _salary = value;
        }

        /// <summary>
        /// Возвращает зарплату.
        /// </summary>
        /// <returns></returns>
        public double GetSalary()
        {
            return _salary;
        }

        /// <summary>
        /// Определяет зарплату учителя.
        /// </summary>
        /// <param name="hours">Часы работы.</param>
        /// <returns>Значение зарплаты.</returns>
        public override double CalculateSalary(int hours)
        {
            return GetSalary() * hours * 1.3;
        }
    }
}
