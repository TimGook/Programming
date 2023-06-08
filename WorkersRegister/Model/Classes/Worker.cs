using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersRegister.Classes
{
    /// <summary>
    /// Содержит информацию о работнике.
    /// </summary>
    internal class Worker
    {
        /// <summary>
        /// Личный индитификатор работника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Счётчик экземпляров класса <see cref="Worker"/>.
        /// </summary>
        private static int _allWorkersCount = 0;

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
        /// Возращает индетификатор прямоугольника. 
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

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
                if (Validator.CheckStringContainsOnlyLetters(value))
                {
                    _fullName = value;
                }
                else
                {
                    MessageBox.Show("Неверно введены данные");
                }                
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
                if (Validator.CheckStringContainsOnlyLetters(value)) 
                { 
                    _position = value; 
                }
                else
                {
                    MessageBox.Show("Неверно введены данные");
                }
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
                if (Validator.CheckEmploymentDate(value)) 
                { 
                    _employmentDate = value; 
                }
                else
                {
                    MessageBox.Show("Неверно введены данные");
                }
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
                if (Validator.CheckOnPositiveValue(value)) 
                { 
                    _salary = value; 
                }
                else
                {
                    MessageBox.Show("Неверно введены данные");
                }
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
            _allWorkersCount++;
            Id = _allWorkersCount;

        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Worker"/>.
        /// </summary>
        public Worker()
        {
            _allWorkersCount++;
            Id = _allWorkersCount;
        }

        /// <summary>
        /// Клонирование объекта класса для редактирования его через текстовые поля.
        /// </summary>
        /// <returns>Клонированный объект класса.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}