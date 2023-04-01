using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Rectangle
    {
        private double _length;
        private double _width;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (!Validator.AssertOnPositiveValue(value))
                {
                    throw new ArgumentException("неправильная ширина");
                }
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
                if (!Validator.AssertOnPositiveValue(value))
                {
                    throw new ArgumentException("неправильная длина");
                }
                _length = value;
            }
        }

        public string Color { get; set; }

        //Конструкторы
        public Rectangle(double width, double height, string color)
        {
            Width = width;
            Length = height;
            Color = color;
        }

        public Rectangle()
        {
        }
    }
}
