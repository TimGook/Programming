using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes.Geometry;

namespace Programming.Model.Classes
{
    class Rectangle
    {
        private double _length;
        private double _width;
        private static int _allRectanglesCount = 0;

        //public Point2D Center { get; set; }
        public Point2D Center { get; set; }
        public string Color { get; set; }

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

        public int Id { get; }

        //Конструкторы
        public Rectangle(double width, double lenght, string color, Point2D center)
        {
            Width = width;
            Length = lenght;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        public Rectangle(int width, int lenght, Point2D center)
        {
            Width = width;
            Length = lenght;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        public Rectangle()
        {
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }
    }
}