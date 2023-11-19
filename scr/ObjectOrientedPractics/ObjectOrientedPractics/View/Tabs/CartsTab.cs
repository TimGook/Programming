using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Задаёт список товаров.
        /// </summary>
        internal List<Item> Items
        {
            set
            {
                ItemsListBox.DataSource = null;
                ItemsListBox.DataSource = value;
            }
        }

        /// <summary>
        /// Задаёт список заказчиков.
        /// </summary>
        internal List<Customer> Customers
        {
            set
            {
                CustomersComboBox.DataSource = null;
                CustomersComboBox.DataSource = value;
            }
        }

        /// <summary>
        /// Текущий заказчик.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private BindingList<Item> _currentItems;

        public CartsTab()
        {
            InitializeComponent();
            CartListBox.DataSource = _currentItems;
            CustomersComboBox.SelectedIndex = -1;
            //_currentCustomer.Cart.Items = _currentItems.ToList<Item>();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                _currentCustomer = (Customer)CustomersComboBox.SelectedItem;
                if (_currentCustomer.Cart.Items == null)
                {
                    _currentItems = new BindingList<Item>();
                }
                else
                {
                    _currentItems = new BindingList<Item>(_currentCustomer.Cart.Items);
                }
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                AmountCostLabel.Text = _currentCustomer.Cart.Amount.ToString();
                CartListBox.DataSource = _currentItems;
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                _currentItems.Add((Item)ItemsListBox.SelectedItem);
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                AmountCostLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                if (CartListBox.Items.Count == 0)
                {
                    return;
                }

                if (_currentCustomer.IsPriority == false)
                {
                    _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                    _currentCustomer.Orders.Add(new Order(_currentCustomer.Address, _currentCustomer.Cart, OrderStatus.New, DateTime.Now.ToString()));
                    _currentItems = new BindingList<Item>(); ;
                    ClearOrder();
                }

                else
                {
                    _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                    _currentCustomer.Orders.Add(new PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart, OrderStatus.New, DateTime.Now.ToString()));
                    _currentItems = new BindingList<Item>(); ;
                    ClearOrder();
                }
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                _currentItems.Remove((Item)CartListBox.SelectedItem);
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                AmountCostLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        /// <summary>
        /// Очистка корзины.
        /// </summary>
        private void ClearOrder()
        {
            _currentItems = new BindingList<Item>();
            _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
            CartListBox.DataSource = null;
            AmountCostLabel.Text = "0.0";
        }
    }
}