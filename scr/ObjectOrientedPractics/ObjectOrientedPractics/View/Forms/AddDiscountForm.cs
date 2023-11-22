using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает и задает выбранный индекс покупателя в CustomersListBox.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        internal List<Customer> Customers { get; set; }

        public AddDiscountForm()
        {
            InitializeComponent();
            DiscountCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            DiscountCategoryComboBox.SelectedIndex = -1;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (DiscountCategoryComboBox.SelectedIndex != -1)
            {
                PercentDiscount percentDiscount = new PercentDiscount();
                percentDiscount.DiscountCategory = (Category)DiscountCategoryComboBox.SelectedItem;
                Customers[SelectedIndex].Discounts.Add(percentDiscount);
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
