using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using Rectangle = Programming.Model.Classes.Rectangle;
using Color = Programming.Model.Enums.Color;

namespace Programming
{
    public partial class MainForm : Form
    {
        const int N = 5;

        private Film[] _films = new Film[N];
        private Film _currentFilm = new Film();
 
        private Rectangle[] _rectangles = new Rectangle[N];
        private Rectangle _currentRectangle = new Rectangle();

        string[] FilmNames = { "Oblivion", "The Green Mile", "The Lord of the Rings: The Return of the King", "Interstellar" , "Avatar" };

        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        private Rectangle _currentDrawnRectangle = new Rectangle();

        private Point2D _point2D = new Point2D();
        private List<Panel> _rectanglePanels = new List<Panel>();


        public MainForm()
        {
            InitializeComponent();

            // Инициализация массива прямоугольников
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize(random.Next(100,200), random.Next(100,200));
                //_rectangles[i] = new Rectangle(random.NextDouble() * 100, random.NextDouble() * 100, Enum.ToObject(typeof(Color), random.Next(0, 5)).ToString(), new Point2D(random.Next(0,100),random.Next(0,100)));
            }

            // Инициализация массива фильмов
            for (int i = 0; i < N; i++)
            {
                _films[i] = new Film(
                    FilmNames[i], random.Next(51, 240), random.Next(1900, 2024),
                    Enum.ToObject(typeof(Genre), random.Next(0, 7)).ToString(), Math.Round(random.NextDouble() * 10, 2));
            }

            //создание массива значений перечисления Season
            var seasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();

            //добавление элементов в ChooseSeasonComboBox из массива занчений seasonValues
            ChooseSeasonComboBox.Items.AddRange(seasonValues);  
            
            //выбор 1-го элемента под индексом 0 из seasonValues
            ChooseSeasonComboBox.SelectedItem = seasonValues[0]; 

            EnumsListBox.SelectedIndex = 0;
        }


        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) //при изменении выбранного элемента в EnumsListBox добавляет в ValuesListBox значения перечисления
        {
            ValuesListBox.Items.Clear(); //очистка ValuesListBox(чтобы не было повторяющихся элементов)
            Type type = Type.GetType($"Programming.Model.Enums.{EnumsListBox.SelectedItem}"); //получение типа перечисления с указанным именем
            var values = Enum.GetValues(type);  //создание массива значений выбранного перечисления

            foreach (var value in values)       //добавление элементов перечисления в ValuesListBox
            {
                ValuesListBox.Items.Add(value);
            }

            IntValuesTextBox.Text = "";
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)  //при изменении выбранного элемента в ValuesListBox указывает индекс элемента перечисления в IntValuesTextBox
        {
            Type type = Type.GetType($"Programming.Model.Enums.{EnumsListBox.SelectedItem}");
            var intValue = Enum.Parse(type, ValuesListBox.SelectedItem.ToString());   //получение значение перечисления из ValuesListBox
            IntValuesTextBox.Text = ((int)intValue).ToString(); //преобразовение значения перечисления в число(и для того, чтобы вывести в IntValuesTextBox, в строку)
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e) //проверка введённого значения и установление соответствия(например, Monday = 1)
        {
            Weekday Day;
 
            if (Enum.TryParse(WeekdayParsingTextBox.Text, true, out Day) && Enum.IsDefined(typeof(Weekday), (int)Day)) //проверка, является ли указанное значение значением перечисления
            {
                ResultLabel.Text = $"Это день недели ({WeekdayParsingTextBox.Text} = {(int)Day})";
            }
            else if (string.IsNullOrEmpty(WeekdayParsingTextBox.Text))
            {
                ResultLabel.Text = "Укажите день недели на английском языке";
            }
            else
            {
                ResultLabel.Text = "Нет такого дня недели";
            }         
        }

        private void GoButton_Click(object sender, EventArgs e)  //при выборе определённого времени года 
        {
            HandleGroupBox.BackColor = System.Drawing.Color.White; //если ничего не было выбрано меняет фон HandleGroupBox на белый

            switch (ChooseSeasonComboBox.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!"); //при выборе лета показывыет всплывающее сообщение "Ура! Солнце!"
                    break;

                case Season.Autumn:
                    HandleGroupBox.BackColor = System.Drawing.Color.FromArgb(226, 156, 69); //при выборе осени меняет фон HandleGroupBox на оранжевый
                    break;

                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!"); //при выборе зимы показывыет всплывающее сообщение "Бррр! Холодно!"
                    break;

                case Season.Spring:
                    HandleGroupBox.BackColor = System.Drawing.Color.FromArgb(85, 156, 69); //при выборе весны меняет фон HandleGroupBox на зелёный
                    break;

                default:
                    HandleGroupBox.BackColor = System.Drawing.Color.White; //если ничего не было выбрано меняет фон HandleGroupBox на белый
                    break;
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
                RectangleLengthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Length = lengthRectangle;
            }
            catch (FormatException)
            {
                RectangleLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                RectangleLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                RectangleLengthTextBox.BackColor = System.Drawing.Color.LightPink;
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
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = widthRectangle;

            }
            catch (FormatException)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
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
                    RectangleColorTextBox.BackColor = System.Drawing.Color.White;
                    _currentRectangle.Color = colorRectangle;
                }
                else
                {
                    RectangleColorTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (FormatException)
            {
                RectangleColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                RectangleColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                RectangleColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }


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

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexFilm = FilmsListBox.SelectedIndex;
            _currentFilm = _films[indexFilm];
            FilmNameTextBox.Text = _currentFilm.Name;
            FilmRatingTextBox.Text = _currentFilm.Rating.ToString();
            FilmGenreTextBox.Text = _currentFilm.Genre;
            FilmRunTimeTextBox.Text = _currentFilm.RunTimeInMinutes.ToString();
            FilmReleaseDateTextBox.Text = _currentFilm.ReleaseDate.ToString();
        }

        private void FilmGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FilmGenreTextBox.Text))
                {
                    return;
                }
                var value = Convert.ToString(FilmGenreTextBox.Text);

                if (Enum.IsDefined(typeof(Genre), value))
                {
                    FilmGenreTextBox.BackColor = System.Drawing.Color.White;
                    _currentFilm.Genre = value;
                }
                else
                {
                    FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            catch (FormatException)
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private int FindFilmWithMaxRating(Film[] _films)
        {
            double maxRating = Double.MinValue;
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                if (_films[i].Rating > maxRating)
                {
                    maxRating = _films[i].Rating;
                    index = i;
                }
            }
            return index;
        }

        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }

        private void FilmRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FilmRatingTextBox.Text))
                {
                    return;
                }

                var value = double.Parse(FilmRatingTextBox.Text);
                FilmRatingTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.Rating = value;

            }
            catch (OverflowException)
            {
                FilmRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }

            catch (ArgumentException)
            {
                FilmRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                FilmRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmReleaseDateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FilmReleaseDateTextBox.Text)) 
                {
                    return;
                }
                var value = int.Parse(FilmReleaseDateTextBox.Text);
                FilmReleaseDateTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.ReleaseDate = value;
            }
            catch (FormatException)
            {
                FilmReleaseDateTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                FilmReleaseDateTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                FilmReleaseDateTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmRunTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FilmRunTimeTextBox.Text))
                {
                    return;
                }
                var value = int.Parse(FilmRunTimeTextBox.Text);
                FilmRunTimeTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.RunTimeInMinutes = value;
            }
            catch (FormatException)
            {
                FilmRunTimeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                FilmRunTimeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                FilmRunTimeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FilmNameTextBox.Text))
                {
                    return;
                }
                var value = FilmNameTextBox.Text;
                FilmNameTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.Name = value;
            }
            catch (FormatException)
            {
                FilmNameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                FilmNameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                FilmNameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmGenreTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FilmGenreTextBox.Text))
                {
                    return;
                }
                var value = FilmGenreTextBox.Text;
                FilmGenreTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.Genre = value;
            }
            catch (FormatException)
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }





        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            var length = random.Next(100, 150);
            var width = random.Next(100, 150);
            var pointX = random.Next(15, 300);
            var pointY = random.Next(15, 300);
            //_point2D = new Point2D(pointX, pointY);

            _currentDrawnRectangle = RectangleFactory.Randomize(width, length);
            _rectanglesList.Add(_currentDrawnRectangle);
            DrawnRectanglesListBox.Items.Add($"{_currentDrawnRectangle.Id}: (X= {_currentDrawnRectangle.Center.X}; " +
                $"Y = {_currentDrawnRectangle.Center.Y}; W= {_currentDrawnRectangle.Width}; H= {_currentDrawnRectangle.Length})");

            Panel currentRectanglePanel = new Panel();
            int intLength = Convert.ToInt32(_currentDrawnRectangle.Length);
            int intWidth = Convert.ToInt32(_currentDrawnRectangle.Width);
            currentRectanglePanel.Location = new Point(pointX, pointY);
            currentRectanglePanel.Size = new Size(intWidth, intLength);
            currentRectanglePanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
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
                DrawnRectangleXTextBox.Text = _currentDrawnRectangle.Center.X.ToString();
                DrawnRectangleYTextBox.Text = _currentDrawnRectangle.Center.Y.ToString();
                DrawnRectangleWidthTextBox.Text = _currentDrawnRectangle.Width.ToString();
                DrawnRectangleLengthTextBox.Text = _currentDrawnRectangle.Length.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                DrawnRectanglesListBox.ClearSelected();
                ClearRectangleInfo();
            }
        }

        private void ClearRectangleInfo()
        {
            DrawnRectangleIdTextBox.Clear();
            DrawnRectangleXTextBox.Clear();
            DrawnRectangleYTextBox.Clear();
            DrawnRectangleWidthTextBox.Clear();
            DrawnRectangleLengthTextBox.Clear();

            DrawnRectangleIdTextBox.BackColor = System.Drawing.Color.White;
            DrawnRectangleXTextBox.BackColor = System.Drawing.Color.White;
            DrawnRectangleYTextBox.BackColor = System.Drawing.Color.White;
            DrawnRectangleWidthTextBox.BackColor = System.Drawing.Color.White;
            DrawnRectangleLengthTextBox.BackColor = System.Drawing.Color.White;
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
                DrawnRectangleXTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                DrawnRectangleXTextBox.BackColor = System.Drawing.Color.LightPink;
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
                DrawnRectangleYTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                DrawnRectangleYTextBox.BackColor = System.Drawing.Color.LightPink;
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
                DrawnRectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                DrawnRectangleYTextBox.BackColor = System.Drawing.Color.LightPink;
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
                DrawnRectangleLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                DrawnRectangleYTextBox.BackColor = System.Drawing.Color.LightPink;
            }

            FindCollisions();
        }

        private void FindCollisions()
        {
            if (_rectanglesList.Count > 1)
            {
                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127);
                }

                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    for (int j = 0; j < _rectanglesList.Count; j++)
                    {
                        if (_rectanglePanels[i] != _rectanglePanels[j])
                        {
                            if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                            {
                                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                                _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
                            }
                        }
                    }
                }
            }
        }

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