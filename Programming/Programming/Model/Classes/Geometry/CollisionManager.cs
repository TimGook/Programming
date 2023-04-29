using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes.Geometry;

namespace Programming.Model.Classes
{
    class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var dX = Math.Abs((rectangle1.Center.X + rectangle1.Width / 2) -
                    (rectangle2.Center.X + rectangle2.Width / 2));
            var dY = Math.Abs((rectangle1.Center.Y + rectangle1.Length / 2) -
                (rectangle2.Center.Y + rectangle2.Length / 2));
            return (dX < Math.Abs(rectangle1.Width / 2 + rectangle2.Width / 2) &&
                (dY < Math.Abs(rectangle1.Length / 2 + rectangle2.Length / 2)));
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var C = Math.Sqrt(Math.Pow(ring1.Center.X, 2) + Math.Pow(ring1.Center.Y, 2));
            return (C < (ring1.ExternalRadius + ring2.ExternalRadius));
        }
    }
}