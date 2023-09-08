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
    /// Control времён года.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            
            var seasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();

            //добавление элементов в ChooseSeasonComboBox из массива занчений seasonValues.
            ChooseSeasonComboBox.Items.AddRange(seasonValues);

            //выбор 1-го элемента под индексом 0 из seasonValues.
            ChooseSeasonComboBox.SelectedItem = seasonValues[0];
        }

        //при выборе определённого времени года.
        private void GoButton_Click(object sender, EventArgs e)  
        {
            HandleGroupBox.BackColor = AppColors.White; 

            switch (ChooseSeasonComboBox.SelectedItem)
            {
                //при выборе лета показывыет всплывающее сообщение "Ура! Солнце!".
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!"); 
                    break;

                //при выборе осени меняет фон HandleGroupBox на оранжевый
                case Season.Autumn:
                    HandleGroupBox.BackColor = AppColors.Orange; 
                    break;

                //при выборе зимы показывыет всплывающее сообщение "Бррр! Холодно!".
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!"); 
                    break;

                //при выборе весны меняет фон HandleGroupBox на зелёный.
                case Season.Spring:
                    HandleGroupBox.BackColor = AppColors.Green; 
                    break;

                //если ничего не было выбрано меняет фон HandleGroupBox на белый.
                default:
                    HandleGroupBox.BackColor = AppColors.White; 
                    break;
            }
        }
    }
}
