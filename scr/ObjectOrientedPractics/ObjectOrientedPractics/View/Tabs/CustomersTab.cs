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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
            //_customersList = CustomersSerializer.LoadCustomers();
            CustomersListBox.DataSource = _customersList;
            ClearCustomersInfo();
            CustomersListBox.SelectedIndex = -1;
            ToggleInputBoxes(false);
            ApplyCustomerInfoChangesButton.Enabled = false;
            ApplyCustomerInfoChangesButton.Visible = false;
        }

        /// <summary>
        /// Правильность ввода имени заказчика.
        /// </summary>
        private bool IsValidCustomerName = true;

        /// <summary>
        /// Правильность ввода адреса заказчика.
        /// </summary>
        private bool IsValidCustomerAddress = true;

        /// <summary>
        /// Список заказчиков.
        /// </summary>
        private List<Customer> _customersList = new List<Customer>();

        /// <summary>
        /// Выбранный заказчик.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Копия выбранного заказчика.
        /// </summary>
        private Customer _clonedCurrentCustomer = new Customer();

        /// <summary>
        /// Индекс текущего выбранного элемента для сортировки 
        /// и сохранения выбранного элемента в ListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _clonedCurrentCustomer = (Customer)_customersList[CustomersListBox.SelectedIndex].Clone();
                SelectedCustomerFullNameTextBox.Text = _clonedCurrentCustomer.Fullname;
                SelectedCustomerAddressTextBox.Text = _clonedCurrentCustomer.Address;
                SelectedCustomerIdTextBox.Text = _clonedCurrentCustomer.Id.ToString();
                EditCustomerButton.Enabled = true;
                ApplyCustomerInfoChangesButton.Enabled = false;
                ApplyCustomerInfoChangesButton.Visible = false;
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            ClearCustomersInfo();
            CustomersListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
            EditCustomerButton.Enabled = false;
            ApplyCustomerInfoChangesButton.Enabled = true;
            ApplyCustomerInfoChangesButton.Visible = true;
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer = _customersList[CustomersListBox.SelectedIndex];
            _customersList.Remove(_currentCustomer);
            CustomersListBox.SelectedIndex = -1;
            //CustomersSerializer.Save(_customersList);
            Sort();
            ClearCustomersInfo();
            EditCustomerButton.Enabled = false;
            ApplyCustomerInfoChangesButton.Enabled = false;
            ApplyCustomerInfoChangesButton.Visible = false;
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = CustomersListBox.SelectedIndex;
            _clonedCurrentCustomer = (Customer)_customersList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
            ApplyCustomerInfoChangesButton.Enabled = true;
            ApplyCustomerInfoChangesButton.Visible = true;
        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SelectedCustomerFullNameTextBox.Text))
                {
                    _clonedCurrentCustomer.Fullname = SelectedCustomerFullNameTextBox.Text;
                    SelectedCustomerFullNameTextBox.BackColor = Color.White;
                    IsValidCustomerName = true;
                    CustomerErrorsLabel.Visible = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidCustomerName = false;
                SelectedCustomerFullNameTextBox.BackColor = Color.LightPink;
                CustomerErrorsLabel.Text = "Необходимо указать имя заказчика.";
                CustomerErrorsLabel.Visible = true;
                CheckData();
            }
            catch (FormatException)
            {
                IsValidCustomerName = false;
                SelectedCustomerFullNameTextBox.BackColor = Color.LightPink;
                CustomerErrorsLabel.Text = "Необходимо указать имя заказчика.";
                CustomerErrorsLabel.Visible = true;
                CheckData();
            }
            //catch (OverflowException)
            //{
            //    IsValidCustomerName = false;
            //    SelectedCustomerFullNameTextBox.BackColor = Color.LightPink;
            //    CustomerErrorsLabel.Text = "Необходимо указать имя заказчика.";
            //    CustomerErrorsLabel.Visible = true;
            //    CheckData();
            //}
        }

        private void CustomerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SelectedCustomerAddressTextBox.Text))
                {
                    _clonedCurrentCustomer.Address = SelectedCustomerAddressTextBox.Text;
                    SelectedCustomerAddressTextBox.BackColor = Color.White;
                    IsValidCustomerAddress = true;
                    CustomerErrorsLabel.Visible = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidCustomerAddress = false;
                SelectedCustomerAddressTextBox.BackColor = Color.LightPink;
                CustomerErrorsLabel.Text = "Необходимо указать адрес заказчика.";
                CustomerErrorsLabel.Visible = true;
                CheckData();
            }
            catch (FormatException)
            {
                IsValidCustomerAddress = false;
                SelectedCustomerAddressTextBox.BackColor = Color.LightPink;
                CustomerErrorsLabel.Text = "Необходимо указать адрес заказчика.";
                CustomerErrorsLabel.Visible = true;
                CheckData();
            }
            //catch (OverflowException)
            //{
            //    IsValidCustomerAddress = false;
            //    SelectedCustomerAddressTextBox.BackColor = Color.LightPink;
            //    CustomerErrorsLabel.Text = "Необходимо указать адрес заказчика.";
            //    CustomerErrorsLabel.Visible = true;
            //    CheckData();
            //}
        }

        private void ApplyCustomerInfoChangesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedCustomerFullNameTextBox.Text) ||
                string.IsNullOrEmpty(SelectedCustomerAddressTextBox.Text))
            {
                CustomerErrorsLabel.Text = "Необходимо заполнить все поля.";
                CustomerErrorsLabel.Visible = true;
            }
            else
            {
                if (_selectedIndex == -1)
                {
                    _currentCustomer = new Customer(
                        SelectedCustomerFullNameTextBox.Text,
                        SelectedCustomerAddressTextBox.Text);
                    _customersList.Add(_currentCustomer);
                    Sort();
                    //CustomersSerializer.Save(_customersList);
                }
                else
                {
                    _customersList[_selectedIndex] = _clonedCurrentCustomer;
                    _currentCustomer = _clonedCurrentCustomer;
                }

                Sort();
                UpdateCusotmerInfo();
                //CustomersSerializer.Save(_customersList);
                ToggleInputBoxes(false);
                ClearCustomersInfo();
                ApplyCustomerInfoChangesButton.Enabled = false;
                ApplyCustomerInfoChangesButton.Visible = false;
                CustomerErrorsLabel.Visible = false;
                CustomersListBox.SelectedIndex = -1;
            }
        }

            /// <summary>
            /// Метод, проверяющий значения текстовых полей и не дающий их сохранить в случае неправильного ввода.
            /// </summary>
            private void CheckData()
        {
            if (IsValidCustomerName && IsValidCustomerAddress)
            {
                ApplyCustomerInfoChangesButton.Enabled = true;
                ApplyCustomerInfoChangesButton.Visible = true;
            }
            else
            {
                ApplyCustomerInfoChangesButton.Enabled = false;
                ApplyCustomerInfoChangesButton.Visible = false;
            }
        }

        /// <summary>
        /// Метод, который включает или отключает все элементы.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            SelectedCustomerFullNameTextBox.Enabled = value;
            SelectedCustomerAddressTextBox.Enabled = value;
        }

        /// <summary>
        /// Метод, который обновляет данные выбранного товара в TextBox и ComboBox.
        /// </summary>
        private void UpdateCusotmerInfo()
        {
            SelectedCustomerFullNameTextBox.Text = _currentCustomer.Fullname;
            SelectedCustomerAddressTextBox.Text = _currentCustomer.Address;
            SelectedCustomerIdTextBox.Text = _currentCustomer.Id.ToString();
        }

        /// <summary>
        /// Метод, который сортирует <see cref="_customersList"/> и <see cref="CustomersListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = CustomersListBox.SelectedIndex;
            CustomersListBox.SelectedIndexChanged -= CustomersListBox_SelectedIndexChanged;
            _customersList = _customersList.OrderBy(customer => customer.Fullname).ToList();
            CustomersListBox.DataSource = _customersList;
            CustomersListBox.SelectedIndex = _indexBeforeSort;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод, который очищает текстовые поля и ComboBox.
        /// </summary>
        private void ClearCustomersInfo()
        {
            SelectedCustomerFullNameTextBox.Clear();
            SelectedCustomerAddressTextBox.Clear();
            SelectedCustomerIdTextBox.Clear();
            ApplyCustomerInfoChangesButton.Enabled = true;
            ApplyCustomerInfoChangesButton.Visible = true;
            CustomerErrorsLabel.Visible = false;
            //PositionErrorLabel.Visible = false;
            //EmploymentDateErrorLabel.Visible = false;
            //SalaryErrorLabel.Visible = false;
            //ApplyErrorLabel.Visible = false;
            SelectedCustomerFullNameTextBox.BackColor = Color.White;
            SelectedCustomerAddressTextBox.BackColor = Color.White;
        }
    }
}