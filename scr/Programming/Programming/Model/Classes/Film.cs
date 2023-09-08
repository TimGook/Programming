using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит информацию о фильме.
    /// </summary>
    internal class Film
    {
        /// <summary>
        /// Минимальная дата релиза.
        /// </summary>
        private const int DateFrom = 1900;

        /// <summary>
        /// Максимальная дата релиза.
        /// </summary>
        private const int DateTo = 2023;

        /// <summary>
        /// Минимальный рейтинг фильма.
        /// </summary>
        private const double RatingFrom = 0.0;

        /// <summary>
        /// Максимальный рейтинг фильма.
        /// </summary>
        private const double RatingTo = 10.0;

        /// <summary>
        /// Максимальная продолжительность фильма.
        /// </summary>
        private const int MaxRunTimeInMinutes = 51420;

        /// <summary>
        /// Рейтинг.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Продолжительность фильма.
        /// </summary>
        private int _runTimeInMinutes;

        /// <summary>
        /// Дата релиза.
        /// </summary>
        private int _releaseDate;

        /// <summary>
        /// Задаёт и возвращает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Задаёт и возвращает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Задаёт и возвращает дату релиза фильма. Должна быть больше 1900 и меньше 2023.
        /// </summary>
        public int ReleaseDate
        {
            get
            {
                return _releaseDate;
            }
            set
            {
                Validator.AssertValueInRange(value, DateFrom, DateTo);                
                _releaseDate = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает продолжительность фильма. Должна быть больше 0 и меьнше 51420.
        /// </summary>
        public int RunTimeInMinutes
        {
            get
            {
                return _runTimeInMinutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, MaxRunTimeInMinutes);
                _runTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает рейтинг фильма. Должен быть больше 0.0 и меньше 10.0.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, RatingFrom, RatingTo);
                _rating = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film"/>.
        /// </summary>
        /// <param name="name"> Название фильма. </param>
        /// <param name="runTimeInMinutes"> Продолжительность фильма. Должна быть больше 0 и меьнше 51420. </param>
        /// <param name="releaseDate"> Дата релиза фильма. Должна быть больше 1900 и меньше 2023. </param>
        /// <param name="genre"> Жанр фильма. </param>
        /// <param name="rating"> Рейтинг фильма. Должен быть больше 0.0 и меньше 10.0. </param>
        public Film(string name, int runTimeInMinutes, int releaseDate, string genre, double rating)
        {
            Name = name;
            RunTimeInMinutes = runTimeInMinutes;
            ReleaseDate = releaseDate;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Film"/>.
        /// </summary>
        public Film()
        {

        }
    }
}