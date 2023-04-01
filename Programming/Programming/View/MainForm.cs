using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;

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


        public MainForm()
        {
            InitializeComponent();

            // Инициализация массива прямоугольников
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                _rectangles[i] = new Rectangle(random.NextDouble() * 100, random.NextDouble() * 100, Enum.ToObject(typeof(Color), random.Next(0, 5)).ToString());
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
                    _currentRectangle.Color = value;
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
    }
}
