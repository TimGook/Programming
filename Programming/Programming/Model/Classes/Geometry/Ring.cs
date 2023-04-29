using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    class Ring
    {
        private double _internalRadius;
        private double _externalRadius;

        public Point2D Center { get; set; }

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

        public Ring(double internalRadius, double externalRadius, double area)
        {
            InternalRadius = internalRadius;
            ExternalRadius = externalRadius;
            Area = area;
        }

        public Ring()
        {

        }
    }
}