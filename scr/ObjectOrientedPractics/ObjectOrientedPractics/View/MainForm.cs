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
using ObjectOrientedPractics.View.Tabs;

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

            ItemsTab.ItemsChanged += ItemsTab_ItemsChanged;
            CustomersTab.CustomersChanged += CustomersTab_CustomersChanged;
        }

        private void MainFormTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _store.Items = ItemsTab.Items;
            _store.Customers = CustomersTab.Customers;

            //if (MainFormTabControl.SelectedIndex == 2)
            //{
            //    CartsTab.Customers = _store.Customers;
            //    CartsTab.Items = _store.Items;
            //}
            if (MainFormTabControl.SelectedIndex == 3)
            {
                OrdersTab.Customers = _store.Customers;
            }
        }

        //private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _store.Customers = CustomersTab.Customers;
        //    _store.Items = ItemsTab.Items;

        //    CartsTab.Items = _store.Items;
        //    CartsTab.Customers = _store.Customers;
        //    CartsTab.RefreshData();
        //    OrdersTab.Customers = _store.Customers;
        //}

        /// <summary>
        /// Обработчик события ItemsChanged.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            _store.Items = ItemsTab.Items;
            CartsTab.Items = _store.Items;
            //CartsTab.RefreshData();
        }

        /// <summary>
        /// Обработчик события CustomersChanged.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersTab_CustomersChanged(object sender, EventArgs e)
        {
            _store.Customers = CustomersTab.Customers;
            CartsTab.Customers = _store.Customers;
            CartsTab.RefreshData();
        }
    }
}