using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes.Geometry;
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle;
using Color = Programming.Model.Enums.Color;

namespace Programming.View.Panels
{
    /// <summary>
    /// Control, содержаший информацию об прямоугольниках.
    /// </summary>
    public partial class RectanglesInfoControl : UserControl
    {
        /// <summary>
        /// Размер массива экземпляров класса <see cref="Rectangle"/>.
        /// </summary>
        const int N = 5;
        
        /// <summary>
        /// Массив содержащий 5 экземпляров класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[N];

        /// <summary>
        /// Выбранный экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();

        public RectanglesInfoControl()
        {
            InitializeComponent();

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                _rectangles[i] = new Rectangle(random.NextDouble() * 100, random.NextDouble() * 100, Enum.ToObject(typeof(Color), random.Next(0, 5)).ToString(), new Point2D(random.Next(0, 100), random.Next(0, 100)));
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexRectangle];
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
            RectangleCenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleCenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
        }


        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(RectangleLengthTextBox.Text))
                {
                    return;
                }
                var lengthRectangle = Double.Parse(RectangleLengthTextBox.Text);
                RectangleLengthTextBox.BackColor = AppColors.White;
                _currentRectangle.Length = lengthRectangle;
            }
            catch (FormatException)
            {
                RectangleLengthTextBox.BackColor = AppColors.LightPink;
            }
            catch (OverflowException)
            {
                RectangleLengthTextBox.BackColor = AppColors.LightPink;
            }
            catch (ArgumentException)
            {
                RectangleLengthTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(RectangleWidthTextBox.Text))
                {
                    return;
                }
                var widthRectangle = Double.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = AppColors.White;
                _currentRectangle.Width = widthRectangle;

            }
            catch (FormatException)
            {
                RectangleWidthTextBox.BackColor = AppColors.LightPink;
            }
            catch (OverflowException)
            {
                RectangleWidthTextBox.BackColor = AppColors.LightPink;
            }
            catch (ArgumentException)
            {
                RectangleWidthTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(RectangleColorTextBox.Text))
                {
                    return;
                }
                var colorRectangle = Convert.ToString(RectangleColorTextBox.Text);

                if (Enum.IsDefined(typeof(Color), colorRectangle))
                {
                    RectangleColorTextBox.BackColor = AppColors.White;
                    _currentRectangle.Color = colorRectangle;
                }
                else
                {
                    RectangleColorTextBox.BackColor = AppColors.LightPink;
                }
            }
            catch (FormatException)
            {
                RectangleColorTextBox.BackColor = AppColors.LightPink;
            }
            catch (OverflowException)
            {
                RectangleColorTextBox.BackColor = AppColors.LightPink;
            }
            catch (ArgumentException)
            {
                RectangleColorTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Находит экземпляр класса <see cref="Rectangle"/> с наибольшей шириной.
        /// </summary>
        /// <param name="_rectagnles"> Массив экземпляров класса <see cref="Rectangle"/>. </param>
        /// <returns> Индекс. </returns>
        private int FindRectangleWithMaxWidth(Rectangle[] _rectagnles)
        {
            double maxWidth = _rectangles[0].Width;
            int index = 0;
            for (int i = 1; i < N; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    index = i;
                }
            }
            return index;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
