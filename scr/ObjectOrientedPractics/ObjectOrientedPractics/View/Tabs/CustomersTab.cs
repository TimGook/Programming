using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Копия текущего покупателя для изменений.
        /// </summary>
        private Customer _copiedCurrentCustomer = new Customer();

        /// <summary>
        /// Индекс текущего элемента ListBox.
        /// </summary>
        private int _selectedIndex = -1;

        /// <summary>
        /// Правильность ввода имени покупателя. true or false.
        /// </summary>
        private bool _isValidFullName;


        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        internal List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                Sort();
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
            //ProjectSerializer.CustomerssInfo(ref _customers);
            Sort();
            ClearCustomersInfo();
            CustomersListBox.SelectedIndex = -1;
            ToggleInputBoxes(false);
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _selectedIndex = CustomersListBox.SelectedIndex;
                ToggleInputBoxes(false);
                _copiedCurrentCustomer = (Customer)_customers[CustomersListBox.SelectedIndex].Clone();
                SelectedCustomerFullNameTextBox.Text = _copiedCurrentCustomer.Fullname;
                CustomerAddressControl.Address = _copiedCurrentCustomer.Address;
                SelectedCustomerIdTextBox.Text = _copiedCurrentCustomer.Id.ToString();
                PriorityCheckBox.Checked = _copiedCurrentCustomer.IsPriority;

                DiscountsListBox.DataSource = null;
                DiscountsListBox.DataSource = _copiedCurrentCustomer.Discounts;
                DiscountsListBox.DisplayMember = "Info";

                EditCustomerButton.Enabled = true;
                ApplyCustomerInfoChangesButton.Enabled = false;
            }
            else
            {
                EditCustomerButton.Enabled = false;
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _selectedIndex = -1;
            ClearCustomersInfo();
            CustomersListBox.SelectedIndex = _selectedIndex;
            ToggleInputBoxes(true);
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            _customers.Remove(_currentCustomer);
            CustomersListBox.SelectedIndex = -1;
            //ProjectSerializer.SaveItems(ref CustomersListBox, _customers);
            Sort();
            ClearCustomersInfo();
            ApplyCustomerInfoChangesButton.Enabled = false;
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = CustomersListBox.SelectedIndex;
            _copiedCurrentCustomer = (Customer)_customers[_selectedIndex].Clone();
            ToggleInputBoxes(true);
        }

        private void SelectedCustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(SelectedCustomerFullNameTextBox.Text))
                    {
                        _copiedCurrentCustomer.Fullname = SelectedCustomerFullNameTextBox.Text;
                        SelectedCustomerFullNameTextBox.BackColor = Color.White;
                        _isValidFullName = true;
                        CheckData();
                    }
                }
                catch (ArgumentException)
                {
                    _isValidFullName = false;
                    SelectedCustomerFullNameTextBox.BackColor = Color.LightPink;
                    CheckData();
                }

                catch (FormatException)
                {
                    _isValidFullName = false;
                    SelectedCustomerFullNameTextBox.BackColor = Color.LightPink;
                    CheckData();
                }
            }
        }

        private void ApplyCustomerInfoChangesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedCustomerFullNameTextBox.Text) || CustomerAddressControl.AddressIsNullOrEmpty())
            {
                MessageBox.Show("Не введены данные!", "Ошибка ввода данных полей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_selectedIndex == -1)
            {
                _currentCustomer = new Customer(SelectedCustomerFullNameTextBox.Text,
                   new Address(CustomerAddressControl.Address.Index, CustomerAddressControl.Address.Country,
                  CustomerAddressControl.Address.City, CustomerAddressControl.Address.Street,
                  CustomerAddressControl.Address.Building, CustomerAddressControl.Address.Apartment));
                _currentCustomer.IsPriority = PriorityCheckBox.Checked;

                DiscountsListBox.DataSource = null;
                DiscountsListBox.DataSource = _copiedCurrentCustomer.Discounts;
                DiscountsListBox.DisplayMember = "Info";

                _customers.Add(_currentCustomer);
                Sort();
                ClearCustomersInfo();
                ToggleInputBoxes(false);
                //return;
            }
            else
            {
                _customers[_selectedIndex] = _copiedCurrentCustomer;
                _currentCustomer = _copiedCurrentCustomer;
            }

            _selectedIndex = -1;
            Sort();
            ClearCustomersInfo();
            ToggleInputBoxes(false);
        }

        /// <summary>
        /// Вкл. и выкл. поля для данных.
        /// </summary>
        /// <param name="value">true or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            SelectedCustomerFullNameTextBox.Enabled = value;
            CustomerAddressControl.Enabled = value;
            ApplyCustomerInfoChangesButton.Enabled = value;
            PriorityCheckBox.Enabled = value;
            DiscountsPanel.Enabled = value;
        }

        /// <summary>
        /// Сортировка <see cref="CustomersListBox"/>.
        /// </summary>
        private void Sort()
        {
            var _indexBeforeSort = CustomersListBox.SelectedIndex;
            CustomersListBox.SelectedIndexChanged -= CustomersListBox_SelectedIndexChanged;
            _customers = _customers.OrderBy(contact => contact.ToString()).ToList();
            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = _indexBeforeSort;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Обновить информацию о товарах в <see cref="CustomersListBox"/>.
        /// </summary>
        private void UpdateCustomersInfo()
        {
            SelectedCustomerFullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            CustomerAddressControl.Address = _currentCustomer.Address;
            SelectedCustomerIdTextBox.Text = _currentCustomer.Id.ToString();
            PriorityCheckBox.Checked = _currentCustomer.IsPriority;

            DiscountsListBox.DataSource = null;
            DiscountsListBox.DataSource = _copiedCurrentCustomer.Discounts;
            DiscountsListBox.DisplayMember = "Info";
        }

        /// <summary>
        /// Очистить поля данных. 
        /// <see cref="FullNameTextBox"/>
        /// <see cref="AdressTextBox"/>
        /// <see cref="IdTextBox"/>
        /// </summary>
        private void ClearCustomersInfo()
        {
            SelectedCustomerFullNameTextBox.Clear();
            CustomerAddressControl.AddressClear();
            SelectedCustomerIdTextBox.Clear();
            DiscountsListBox.DataSource = null;
            PriorityCheckBox.Enabled = false;
            ApplyCustomerInfoChangesButton.Enabled = true;
        }

        /// <summary>
        /// Проверка на правильный ввод всех полей.
        /// </summary>
        public void CheckData()
        {
            if (CustomerAddressControl.IsValidAddress() && _isValidFullName)
            {
                ApplyCustomerInfoChangesButton.Enabled = true;
            }
            else
            {
                ApplyCustomerInfoChangesButton.Enabled = false;
            }
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _copiedCurrentCustomer.IsPriority = PriorityCheckBox.Checked;
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                AddDiscountForm addDiscountForm = new AddDiscountForm();
                addDiscountForm.SelectedIndex = CustomersListBox.SelectedIndex;
                addDiscountForm.Customers = Customers;
                addDiscountForm.Show();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex > 0)
            {
                _copiedCurrentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            }
            DiscountsListBox.DataSource = null;
            DiscountsListBox.DataSource = _copiedCurrentCustomer.Discounts;
            DiscountsListBox.DisplayMember = "Info";
        }
    }
}