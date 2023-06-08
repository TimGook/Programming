using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет доступ к методу по созданию экземпляра класса <see cref="Rectangle"/> со случайными параметрами.
    /// </summary>
    static class RectangleFactory
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/> со случайными параметрами.
        /// </summary>
        /// <param name="maxWidth"> Максимальная ширина. Должна состоять только из числа. </param>
        /// <param name="maxLength"> Максимальная длина. Должна состоять только из числа.</param>
        /// <returns> Возвращает экземпляр класса <see cref="Rectangle"/>. </returns>
        public static Rectangle Randomize(int maxWidth, int maxLength)
        {
            Random random = new Random();
            int width = random.Next(1, maxWidth);
            int lenght = random.Next(1, maxLength);
            Point2D startPoint = new Point2D(random.Next(15, 300), random.Next(15, 300));
            Rectangle rectangle = new Rectangle(width, lenght, startPoint);

            return rectangle;
        }
    }
}
