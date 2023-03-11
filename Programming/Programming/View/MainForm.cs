using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //создание массива значений перечисления Season
            var seasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            ChooseSeasonComboBox.Items.AddRange(seasonValues);  //добавление элементов в ChooseSeasonComboBox из массива занчений seasonValues 
            ChooseSeasonComboBox.SelectedItem = seasonValues[0]; //выбор 1-го элемента под индексом 0 из seasonValues

            EnumsListBox.SelectedIndex = 0; //выбор 1-го элемента в EnumsListBox
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
            else if (WeekdayParsingTextBox.Text == "")
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
    }
}
