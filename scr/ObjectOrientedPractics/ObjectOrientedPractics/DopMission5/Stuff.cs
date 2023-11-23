using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.DopMission5
{
    /// <summary>
    /// Абстрактный класс для расчёта зарплаты.
    /// </summary>
    abstract class Stuff
    {
        /// <summary>
        /// Чисто виртуальный метод для вычисления зарплаты
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public abstract double CalculateSalary(int hours); 
    }
}
