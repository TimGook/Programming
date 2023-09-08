using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkersApp.Model.Classes
{
    /// <summary>
    /// Содержит информацию о работнике.
    /// </summary>
    internal class Worker
    {
        /// <summary>
        /// Полное имя работника.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Должность работника.
        /// </summary>
        private string _position;

        /// <summary>
        /// Зарплата.
        /// </summary>
        private int _salary;

        /// <summary>
        /// Дата трудоустройства.
        /// </summary>
        private DateTime _employmentDate;

        /// <summary>
        /// Возвращает и задаёт полное имя работника.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт должность работника.
        /// </summary>
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value);
                _position = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт дату трудоустройства.
        /// </summary>
        public DateTime EmploymentDate
        {
            get
            {
                return _employmentDate;
            }
            set
            {
                Validator.AssertEmploymentDate(value);
                _employmentDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёть зарплату.
        /// </summary>
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _salary = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Worker"/>.
        /// </summary>
        /// <param name="fullName"> Полное имя работника. </param>
        /// <param name="position"> Должность работника. </param>
        /// <param name="salary"> Зарплата работника. </param>
        /// <param name="employmentDate"> Дата трудоустройства. </param>
        public Worker(string fullName, string position, int salary, DateTime employmentDate)
        {
            FullName = fullName;
            Position = position;
            Salary = salary;
            EmploymentDate = employmentDate;

        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Worker"/>.
        /// </summary>
        public Worker()
        {

        }

        /// <summary>
        /// Клонирование объекта класса для редактирования его через текстовые поля.
        /// </summary>
        /// <returns>Клонированный объект класса.</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Worker"/>.
        /// </summary>
        /// <returns>Строка: ФИО.</returns>
        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}