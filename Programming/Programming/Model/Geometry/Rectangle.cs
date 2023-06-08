using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes.Geometry;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Индетификатор прямоугольникаю
        /// </summary>
        private int _id;

        /// <summary>
        /// Счётчик экземпляров класса <see cref="Rectangle"/>.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Возвращает и здаёт координаты центра.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возращает и задаёт ширину прямоугальника. Должна быть больше 0.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        /// <summary>
        /// Возращает и задаёт длину прямоугальника. Должна быть больше 0.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }
        
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
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="width"> Ширина прямоугольника. Должна быть больше 0. </param>
        /// <param name="lenght"> Длина прямоугольника. Должна быть больше 0. </param>
        /// <param name="color"> Цвет прямоугольника. Должен быть текстовым типом данных.</param>
        /// <param name="center"> Координаты прямоугольника. Должен быть представлен классом <see cref="Point2D"/>. </param>
        public Rectangle(double width, double lenght, string color, Point2D center)
        {
            Width = width;
            Length = lenght;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="width"> Ширина прямоугольника. Должна быть больше 0. </param>
        /// <param name="lenght"> Длина прямоугольника. Должна быть больше 0. </param>
        /// <param name="center"> Координаты прямоугольника. Должен быть представлен классом <see cref="Point2D"/>. </param>
        public Rectangle(int width, int lenght, Point2D center)
        {
            Width = width;
            Length = lenght;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }
    }
}