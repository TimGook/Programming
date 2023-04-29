using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    static class RectangleFactory
    {
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
