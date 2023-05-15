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
    /// Control, содержащий информацию о перечислениях.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();

            var seasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();

            EnumsListBox.SelectedIndex = 0;
        }

        // При изменении выбранного элемента в EnumsListBox добавляет в ValuesListBox значения перечисления
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            // Очистка ValuesListBox(чтобы не было повторяющихся элементов)
            ValuesListBox.Items.Clear();

            // Получение типа перечисления с указанным именем
            Type type = Type.GetType($"Programming.Model.Enums.{EnumsListBox.SelectedItem}");
            
            // Создание массива значений выбранного перечисления
            var values = Enum.GetValues(type);

            // Добавление элементов перечисления в ValuesListBox
            foreach (var value in values)       
            {
                ValuesListBox.Items.Add(value);
            }

            IntValuesTextBox.Text = "";
        }

        // При изменении выбранного элемента в ValuesListBox указывает индекс элемента перечисления в IntValuesTextBox
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)  
        {
            Type type = Type.GetType($"Programming.Model.Enums.{EnumsListBox.SelectedItem}");

            // Получение значения перечисления из ValuesListBox
            var intValue = Enum.Parse(type, ValuesListBox.SelectedItem.ToString());   

            // Преобразовение значения перечисления в число(и для того, чтобы вывести в IntValuesTextBox, в строку)
            IntValuesTextBox.Text = ((int)intValue).ToString();
        }
    }
}
