using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Содержит цвета.
    /// </summary>
    public class AppColors
    {
        /// <summary>
        /// светло-розовый.
        /// </summary>
        public static readonly Color LightPink = Color.LightPink; 

        /// <summary>
        /// Оранжевый.
        /// </summary>
        public static readonly Color Orange = Color.FromArgb(226, 156, 69);

        /// <summary>
        /// Белый.
        /// </summary>
        public static readonly Color White = Color.White;

        /// <summary>
        /// Зелёный.
        /// </summary>
        public static readonly Color Green = Color.FromArgb(85, 156, 69);

        /// <summary>
        /// Красный.
        /// </summary>
        public static readonly Color Red = Color.FromArgb(255, 0, 0);

        /// <summary>
        /// Светло-зелёный.
        /// </summary>
        public static readonly Color LightGreen = Color.FromArgb(127, 255, 127);
    }
}
