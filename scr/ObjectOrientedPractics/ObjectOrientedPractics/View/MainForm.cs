using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин. Хранит в себе экземпляры товаров и заказчиков.
        /// </summary>
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _store.Items = ItemsTab.Items;
            _store.Customers = CustomersTab.Customers;

            if (MainFormTabControl.SelectedIndex == 2)
            {
                CartsTab.Customers = _store.Customers;
                CartsTab.Items = _store.Items;
            }
            if (MainFormTabControl.SelectedIndex == 3)
            {
                OrdersTab.Customers = _store.Customers;
            }
        }

    }
}
