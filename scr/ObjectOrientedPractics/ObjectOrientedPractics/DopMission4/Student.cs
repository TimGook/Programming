using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.DopMission4
{
    /// <summary>
    /// Содержит информацию о студенте.
    /// </summary>
    class Student:Person
    {
        /// <summary>
        /// Номер курса.
        /// </summary>
        private int _course;

        /// <summary>
        /// Средняя оценка.
        /// </summary>
        private float _averageMart;

        /// <summary>
        /// Задаёт и возвращает номер курса. Не может быть меньше 1.
        /// </summary>
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Номер курса не может быть меньше 1!");
                }
                _course = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает среднюю оценку. Может быть только больше нуля.
        /// </summary>
        public float AverageMark
        {
            get
            {
                return _averageMart;
            }
            set
            {
                if (value > 0f)
                {
                    _averageMart = value;
                }
                else
                {
                    throw new ArgumentException("Средняя оценка должна быть больше 0!");
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр студента.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        /// <param name="course">Номер курса.</param>
        /// <param name="averageMark">Средняя оценка.</param>
        public Student(string firstName, string lastName, int age, int course, float averageMark) : base(firstName, lastName, age)
        {
            Course = course;
            AverageMark = averageMark;
        }
    }
}
