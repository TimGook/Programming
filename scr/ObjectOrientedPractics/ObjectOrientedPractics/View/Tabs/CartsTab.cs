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
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        internal List<Item> Items
        {
            set
            {
                ItemsListBox.DataSource = null;
                ItemsListBox.DataSource = value;
            }
        }

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
        /// Текущие товары в корзине.
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

                DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;
                DiscountsCheckedListBox.DisplayMember = "Info";

                for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
                {
                    DiscountsCheckedListBox.SetItemChecked(i, true);
                }
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                _currentItems.Add((Item)ItemsListBox.SelectedItem);
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                AmountCostLabel.Text = _currentCustomer.Cart.Amount.ToString();
                CartListBox.Refresh();
                RefreshDiscount();
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
                    Order order = new Order(_currentCustomer.Address, _currentCustomer.Cart, OrderStatus.New, DateTime.Now.ToString());
                    order.DiscountAmount = ApplyDiscount();
                    order.Amount = order.Amount - ApplyDiscount();
                    _currentCustomer.Orders.Add(order);
                    _currentItems = new BindingList<Item>();
                    ClearOrder();
                }

                else
                {
                    _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                    Order order = new PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart, OrderStatus.New, DateTime.Now.ToString());
                    order.DiscountAmount = ApplyDiscount();
                    order.Amount = order.Amount - ApplyDiscount();
                    _currentItems = new BindingList<Item>();
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
                CartListBox.Refresh();
                RefreshDiscount();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearOrder();
            CartListBox.DataSource = null;
        }

        private void ClearOrder()
        {
            _currentItems = new BindingList<Item>();
            _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
            CartListBox.DataSource = null;
            RefreshDiscount();
            AmountCostLabel.Text = "0.0";
            CartListBox.Refresh();
            DiscountsCheckedListBox.ClearSelected();
        }

        /// <summary>
        /// Метод, который считает размер скидки.
        /// </summary>
        private void RefreshDiscount()
        {
            double discountAmount = 0;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                discountAmount += _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);

                if (!DiscountsCheckedListBox.GetItemChecked(i))
                {
                    discountAmount -= _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);
                }
            }
            DiscountAmountCostLabel.Text = discountAmount.ToString();
            TotalAmountCostLabel.Text = (_currentCustomer.Cart.Amount - discountAmount).ToString();
        }

        private double ApplyDiscount()
        {
            double discountAmount = 0;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += _currentCustomer.Discounts[i].Apply(_currentCustomer.Cart.Items);
                    _currentCustomer.Discounts[i].Update(_currentCustomer.Cart.Items);
                }
            }
            return discountAmount;
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentCustomer.Discounts != null)
            {
                RefreshDiscount();
            }
        }
    }
}