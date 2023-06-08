using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Control, содержаший информацию о прямоугольниках и отображающий их на Panel.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Список экземпляров класса <see cref="Rectangle"/>.
        /// </summary>
        private List<Rectangle> _rectanglesList = new List<Rectangle>();

        /// <summary>
        /// Выбранный экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle _currentDrawnRectangle = new Rectangle();

        /// <summary>
        /// Координаты центра прямоугольника.
        /// </summary>
        private Point2D _point2D = new Point2D();

        /// <summary>
        /// Список прямоугольников на Panel.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();


        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            var length = random.Next(100, 150);
            var width = random.Next(100, 150);
            var pointX = random.Next(15, 300);
            var pointY = random.Next(15, 300);
   
            _currentDrawnRectangle = RectangleFactory.Randomize(width, length);
            _rectanglesList.Add(_currentDrawnRectangle);
            DrawnRectanglesListBox.Items.Add($"{_currentDrawnRectangle.Id}: (X= {_currentDrawnRectangle.Center.X}; " +
                $"Y = {_currentDrawnRectangle.Center.Y}; W= {_currentDrawnRectangle.Width}; H= {_currentDrawnRectangle.Length})");

            Panel currentRectanglePanel = new Panel();
            int intLength = Convert.ToInt32(_currentDrawnRectangle.Length);
            int intWidth = Convert.ToInt32(_currentDrawnRectangle.Width);
            currentRectanglePanel.Location = new Point(pointX, pointY);
            currentRectanglePanel.Size = new Size(intWidth, intLength);
            currentRectanglePanel.BackColor = AppColors.LightGreen;
            currentRectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Controls.Add(currentRectanglePanel);
            _rectanglePanels.Add(currentRectanglePanel);

            FindCollisions();
        }

        private void DeleteDrawnRectangleButton_Click(object sender, EventArgs e)
        {
            if (DrawnRectanglesListBox.Items.Count > 0 && DrawnRectanglesListBox.SelectedIndex >= 0)
            {
                int indexPanelRectangle = DrawnRectanglesListBox.SelectedIndex;
                _currentDrawnRectangle = _rectanglesList[indexPanelRectangle];
                DrawnRectanglesListBox.Items.RemoveAt(indexPanelRectangle);
                _rectanglesList.Remove(_currentDrawnRectangle);
                RectanglesPanel.Controls.RemoveAt(indexPanelRectangle);
                _rectanglePanels.RemoveAt(indexPanelRectangle);
            }

            FindCollisions();
        }

        private void DrawnRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int indexPanelRectangle = DrawnRectanglesListBox.SelectedIndex;
                _currentDrawnRectangle = _rectanglesList[indexPanelRectangle];


                DrawnRectangleIdTextBox.Text = _currentDrawnRectangle.Id.ToString();
                DrawnRectangleXTextBox.Text = (_currentDrawnRectangle.Center.X.ToString());
                DrawnRectangleYTextBox.Text = (_currentDrawnRectangle.Center.Y.ToString());
                DrawnRectangleWidthTextBox.Text = _currentDrawnRectangle.Width.ToString();
                DrawnRectangleLengthTextBox.Text = _currentDrawnRectangle.Length.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                DrawnRectanglesListBox.ClearSelected();
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Очищает все элементы TextBox и меняет их фоны на белый.
        /// </summary>
        private void ClearRectangleInfo()
        {
            DrawnRectangleIdTextBox.Clear();
            DrawnRectangleXTextBox.Clear();
            DrawnRectangleYTextBox.Clear();
            DrawnRectangleWidthTextBox.Clear();
            DrawnRectangleLengthTextBox.Clear();

            DrawnRectangleIdTextBox.BackColor = AppColors.White;
            DrawnRectangleXTextBox.BackColor = AppColors.White;
            DrawnRectangleYTextBox.BackColor = AppColors.White;
            DrawnRectangleWidthTextBox.BackColor = AppColors.White;
            DrawnRectangleLengthTextBox.BackColor = AppColors.White;
        }

        private void DrawnRectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DrawnRectangleXTextBox.Text))
                {
                    return;
                }

                if (DrawnRectanglesListBox.Items.Count > 0 && DrawnRectanglesListBox.SelectedIndex >= 0)
                {
                    var replaceX = int.Parse(DrawnRectangleXTextBox.Text);
                    var indexDrawnRectangle = DrawnRectanglesListBox.SelectedIndex;
                    _currentDrawnRectangle = _rectanglesList[indexDrawnRectangle];
                    _currentDrawnRectangle.Center.X = replaceX;

                    UpdateRectangleInfo(_currentDrawnRectangle, indexDrawnRectangle);
                }
            }
            catch (ArgumentException)
            {
                DrawnRectangleXTextBox.BackColor = AppColors.LightPink;
            }
            catch (FormatException)
            {
                DrawnRectangleXTextBox.BackColor = AppColors.LightPink;
            }

            FindCollisions();
        }

        private void DrawnRectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DrawnRectangleYTextBox.Text))
                {
                    return;
                }

                if (DrawnRectanglesListBox.Items.Count > 0 && DrawnRectanglesListBox.SelectedIndex >= 0)
                {
                    var replaceY = int.Parse(DrawnRectangleYTextBox.Text);
                    var indexDrawnRectangle = DrawnRectanglesListBox.SelectedIndex;
                    _currentDrawnRectangle = _rectanglesList[indexDrawnRectangle];
                    _currentDrawnRectangle.Center.Y = replaceY;

                    UpdateRectangleInfo(_currentDrawnRectangle, indexDrawnRectangle);
                }
            }
            catch (ArgumentException)
            {
                DrawnRectangleYTextBox.BackColor = AppColors.LightPink;
            }
            catch (FormatException)
            {
                DrawnRectangleYTextBox.BackColor = AppColors.LightPink;
            }

            FindCollisions();
        }

        private void DrawnRectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DrawnRectangleWidthTextBox.Text))
                {
                    return;
                }

                if (DrawnRectanglesListBox.Items.Count > 0 && DrawnRectanglesListBox.SelectedIndex >= 0)
                {
                    var replaceWidth = int.Parse(DrawnRectangleWidthTextBox.Text);
                    var indexDrawnRectangle = DrawnRectanglesListBox.SelectedIndex;
                    _currentDrawnRectangle = _rectanglesList[indexDrawnRectangle];
                    _currentDrawnRectangle.Width = replaceWidth;

                    UpdateRectangleInfo(_currentDrawnRectangle, indexDrawnRectangle);
                }
            }
            catch (ArgumentException)
            {
                DrawnRectangleWidthTextBox.BackColor = AppColors.LightPink;
            }
            catch (FormatException)
            {
                DrawnRectangleYTextBox.BackColor = AppColors.LightPink;
            }

            FindCollisions();
        }

        private void DrawnRectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(DrawnRectangleLengthTextBox.Text))
                {
                    return;
                }

                if (DrawnRectanglesListBox.Items.Count > 0 && DrawnRectanglesListBox.SelectedIndex >= 0)
                {
                    var replaceLength = int.Parse(DrawnRectangleLengthTextBox.Text);
                    var indexDrawnRectangle = DrawnRectanglesListBox.SelectedIndex;
                    _currentDrawnRectangle = _rectanglesList[indexDrawnRectangle];
                    _currentDrawnRectangle.Length = replaceLength;

                    UpdateRectangleInfo(_currentDrawnRectangle, indexDrawnRectangle);
                }
            }
            catch (ArgumentException)
            {
                DrawnRectangleLengthTextBox.BackColor = AppColors.LightPink;
            }
            catch (FormatException)
            {
                DrawnRectangleYTextBox.BackColor = AppColors.LightPink;
            }

            FindCollisions();
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и меняет их цвет на красный.
        /// </summary>
        private void FindCollisions()
        {
            if (_rectanglesList.Count > 1)
            {
                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    _rectanglePanels[i].BackColor = AppColors.LightGreen;
                }

                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    for (int j = 0; j < _rectanglesList.Count; j++)
                    {
                        if (_rectanglePanels[i] != _rectanglePanels[j])
                        {
                            if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                            {
                                _rectanglePanels[i].BackColor = AppColors.Red;
                                _rectanglePanels[j].BackColor = AppColors.Red;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет информацию об изменённом экземпляре класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangle"> Выбранный экземпляр класса <see cref="Rectangle"/>. </param>
        /// <param name="indexDrawnRectangle"> Индекс выбранного экземпляра класса <see cref="Film"/>. </param>
        private void UpdateRectangleInfo(Rectangle rectangle, int indexDrawnRectangle)
        {
            DrawnRectanglesListBox.Items[indexDrawnRectangle] = ($"{rectangle.Id}: " +
                $"(X= {rectangle.Center.X}; " +
                $"Y = {rectangle.Center.Y}; W= {rectangle.Width}; H= {rectangle.Length})");
            Panel currentRectanglePanel = _rectanglePanels[indexDrawnRectangle];
            var currentRectangle = _rectanglesList[indexDrawnRectangle];
            currentRectanglePanel.Location = new Point(currentRectangle.Center.X,
                currentRectangle.Center.Y);
            currentRectanglePanel.Size = new Size(Convert.ToInt32(currentRectangle.Width),
                Convert.ToInt32(currentRectangle.Length));
        }
    }
}
