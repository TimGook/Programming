using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Задаёт 2 координаты точки.
    /// </summary>
    class Point2D
    {
        /// <summary>
        /// Координата точки по X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата точки по Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задаёт координату точки по X.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт координату точки по Y.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x"> Координата точки X. должна быть целым числом. </param>
        /// <param name="y"> Координата точки Y. должна быть целым числом. </param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D()
        {

        }      
    }
}