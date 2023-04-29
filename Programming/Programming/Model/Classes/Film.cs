using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Film
    {
        private const int DateFrom = 1900;
        private const int DateTo = 2023;

        private const double RatingFrom = 0.0;
        private const double RatingTo = 10.0;

        private const int MaxRunTimeInMinutes = 51420;

        // Рейтинг от 0 до 10
        private double _rating;

        // Целочисленное поле Продолжительность в минутах
        private int _runTimeInMinutes;
        
        // Дата выпуска от 1900 года до текущего года
        private int _releaseDate;

        //Автосвойство Название
        public string Name { get; set; }

        //Автосвойство Жанр
        public string Genre { get; set; }

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

        //Конструкторы
        public Film(string name, int runTimeInMinutes, int releaseDate, string genre, double rating)
        {
            Name = name;
            RunTimeInMinutes = runTimeInMinutes;
            ReleaseDate = releaseDate;
            Genre = genre;
            Rating = rating;
        }

        public Film()
        {

        }
    }
}