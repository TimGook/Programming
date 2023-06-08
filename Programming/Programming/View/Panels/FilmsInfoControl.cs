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
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    /// <summary>
    /// Control, содержащий информацию о фильмах.
    /// </summary>
    public partial class FilmsInfoControl : UserControl
    {
        /// <summary>
        /// Размер массива экземпляров класса <see cref="Film"/>.
        /// </summary>
        const int N = 5;

        /// <summary>
        /// Массив экземпляров класса <see cref="Film"/>.
        /// </summary>
        private Film[] _films = new Film[N];

        /// <summary>
        /// Вырбранный экземпляр класса <see cref="Film"/>.
        /// </summary>
        private Film _currentFilm = new Film();
        
        /// <summary>
        /// Массив названий фильмов.
        /// </summary>
        string[] FilmNames = { "Oblivion", "The Green Mile", "The Lord of the Rings: The Return of the King", "Interstellar", "Avatar" };

        public FilmsInfoControl()
        {
            InitializeComponent();

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                _films[i] = new Film(
                    FilmNames[i], random.Next(51, 250), random.Next(1900, 2023),
                    Enum.ToObject(typeof(Genre), random.Next(0, 6)).ToString(), Math.Round(random.NextDouble() * 10, 2));
            }
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
                    FilmGenreTextBox.BackColor = AppColors.White;
                    _currentFilm.Genre = value;
                }
                else
                {
                    FilmGenreTextBox.BackColor = AppColors.LightPink;
                }
            }
            catch (FormatException)
            {
                FilmGenreTextBox.BackColor = AppColors.LightPink;
            }
            catch (OverflowException)
            {
                FilmGenreTextBox.BackColor = AppColors.LightPink;
            }
            catch (ArgumentException)
            {
                FilmGenreTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Находит экземпляр класса <see cref="Film"/> с наибольшим рейтингом.
        /// </summary>
        /// <param name="_films"> Массив экземпляров класса <see cref="Film"/>. </param>
        /// <returns> Индек. </returns>
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
                FilmRatingTextBox.BackColor = AppColors.White;
                _currentFilm.Rating = value;

            }
            catch (OverflowException)
            {
                FilmRatingTextBox.BackColor = AppColors.LightPink;
            }

            catch (ArgumentException)
            {
                FilmRatingTextBox.BackColor = AppColors.LightPink;
            }
            catch (FormatException)
            {
                FilmRatingTextBox.BackColor = AppColors.LightPink;
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
                FilmReleaseDateTextBox.BackColor = AppColors.White;
                _currentFilm.ReleaseDate = value;
            }
            catch (FormatException)
            {
                FilmReleaseDateTextBox.BackColor = AppColors.LightPink;
            }
            catch (OverflowException)
            {
                FilmReleaseDateTextBox.BackColor = AppColors.LightPink;
            }
            catch (ArgumentException)
            {
                FilmReleaseDateTextBox.BackColor = AppColors.LightPink;
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
                FilmRunTimeTextBox.BackColor = AppColors.White;
                _currentFilm.RunTimeInMinutes = value;
            }
            catch (FormatException)
            {
                FilmRunTimeTextBox.BackColor = AppColors.LightPink;
            }
            catch (OverflowException)
            {
                FilmRunTimeTextBox.BackColor = AppColors.LightPink;
            }
            catch (ArgumentException)
            {
                FilmRunTimeTextBox.BackColor = AppColors.LightPink;
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
                FilmNameTextBox.BackColor = AppColors.White;
                _currentFilm.Name = value;
            }
            catch (FormatException)
            {
                FilmNameTextBox.BackColor = AppColors.LightPink;
            }
            catch (OverflowException)
            {
                FilmNameTextBox.BackColor = AppColors.LightPink;
            }
            catch (ArgumentException)
            {
                FilmNameTextBox.BackColor = AppColors.LightPink;
            }
        }
    }
}
