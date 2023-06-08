using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    class Ring
    {
        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _internalRadius;

        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _externalRadius;

        /// <summary>
        /// Координаты центра.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт внутренний радиус кольца. Должен быть больше 0 и меньше внешнего радиуса.
        /// </summary>
        public double InternalRadius
        {
            get
            {
                return _internalRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _internalRadius = value;
            }
        }

        /// <summary>
        /// /// Возвращает и задаёт внутренний радиус кольца. Должен быть больше 0 и больше внетреннего радиуса.
        /// </summary>
        public double ExternalRadius
        {
            get
            {
                return _externalRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _externalRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт площадь кольца. Должна быть больше 0.
        /// </summary>
        public double Area
        {
            get
            {
                return _externalRadius * _externalRadius * Math.PI - _internalRadius * _internalRadius * Math.PI;
            }
            private set
            {
                Area = value;
            }

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="internalRadius"> Внутренний радиус. Должен быть больше 0 и меньше внешнего радиуса.</param>
        /// <param name="externalRadius"> Внешний радиус. Должен быть больше 0 и больше внешнего радиуса.</param>
        /// <param name="area"></param>
        public Ring(double internalRadius, double externalRadius, double area)
        {
            InternalRadius = internalRadius;
            ExternalRadius = externalRadius;
            Area = area;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Ring"/>.
        /// </summary>
        public Ring()
        {

        }
    }
}