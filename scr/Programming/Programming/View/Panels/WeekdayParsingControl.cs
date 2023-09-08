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

namespace Programming.View.Panels
{   
    /// <summary>
    /// Control для парсинга дней недели.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        // Проверка введённого значения и установление соответствия(например, Monday = 1).
        private void WeekdayParsingButton_Click(object sender, EventArgs e) 
        {
            Weekday Day;

            // Проверка, является ли указанное значение значением перечисления.
            if (Enum.TryParse(WeekdayParsingTextBox.Text, true, out Day) && Enum.IsDefined(typeof(Weekday), (int)Day)) 
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
    }
}
