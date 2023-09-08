using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Classes.Geometry;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Проверка на пересечение геометрических фигур.
    /// </summary>
    class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются 2 прямоугольника или нет.
        /// </summary>
        /// <param name="rectangle1"> Экземпляр класса <see cref="Rectangle">. </param>
        /// <param name="rectangle2"> Экземпляр класса <see cref="Rectangle">. </param>
        /// <returns> Возвращает true, если пересечение есть, и false, если пересечения нет. </returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var dX = Math.Abs((rectangle1.Center.X + rectangle1.Width / 2) -
                    (rectangle2.Center.X + rectangle2.Width / 2));
            var dY = Math.Abs((rectangle1.Center.Y + rectangle1.Length / 2) -
                (rectangle2.Center.Y + rectangle2.Length / 2));
            return (dX < Math.Abs(rectangle1.Width / 2 + rectangle2.Width / 2) &&
                (dY < Math.Abs(rectangle1.Length / 2 + rectangle2.Length / 2)));
        }

        /// <summary>
        /// Проверяет, пересекаются 2 кольца или нет.
        /// </summary>
        /// <param name="ring1"> Экземпляр класса <see cref="Ring">. </param>
        /// <param name="ring2"> Экземпляр класса <see cref="Ring">. </param>
        /// <returns> Возвращает true, если пересечение есть, и false, если пересечения нет. </returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var C = Math.Sqrt(Math.Pow(ring1.Center.X, 2) + Math.Pow(ring1.Center.Y, 2));
            return (C < (ring1.ExternalRadius + ring2.ExternalRadius));
        }
    }
}