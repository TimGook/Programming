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
    public partial class PriorityOrderTab : UserControl
    {
        /// <summary>
        /// Счётчик id.
        /// </summary>
        private int _idCounter = 0;
        
        /// <summary>
        /// Текущий приоритетный заказ <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder _priorityOrder = new PriorityOrder();

        /// <summary>
        /// Возвращает и задает приоритетный заказ.
        /// </summary>
        internal PriorityOrder PriorityOrder
        {
            get => _priorityOrder;
            set => _priorityOrder = value;
        }

        /// <summary>
        /// экземпляр класса <see cref="Random"/>.
        /// </summary>
        private Random random = new Random();

        public PriorityOrderTab()
        {
            InitializeComponent();

            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            DeliveryAddressControl.Address = new Address(random.Next(100000,999999),"Рандомная страна", "Рандомный город","Рандомная улица","Рандомное строение","Рандомная квартира");
            DeliveryAddressControl.AddressClear();

            PriorityOrder.Items = new List<Item>(); 

            DateTime date = DateTime.Now;
            IdTextBox.Text = _idCounter.ToString();
            CreatedTextBox.Text = date.ToString();
            PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;

            for (int i = 0; i < Enum.GetNames(typeof(DesiredDeliveryTime)).Length; i++)
            {
                var enumType = typeof(DesiredDeliveryTime);
                var memberInfos =
                enumType.GetMember(Enum.Parse(typeof(DesiredDeliveryTime), i.ToString()).ToString());
                var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
                var valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                var description = ((DescriptionAttribute)valueAttributes[0]).Description;
                DeliveryTimeComboBox.Items.Add(description);
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item randomItem = Item.GenerateRandomItem();
            OrderItemsListBox.Items.Add(randomItem);
            PriorityOrder.Items.Add(randomItem);
            AmountCostLabel.Text = PriorityOrder.Amount.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count > 0 && OrderItemsListBox.SelectedIndex != -1)
            {
                AmountCostLabel.Text = PriorityOrder.Amount.ToString();

                int selectedIndex = OrderItemsListBox.SelectedIndex;
                PriorityOrder.Items.RemoveAt(selectedIndex);
                OrderItemsListBox.Items.RemoveAt(selectedIndex);

                if (selectedIndex == OrderItemsListBox.Items.Count)
                {
                    OrderItemsListBox.SelectedIndex = selectedIndex - 1;
                    return;
                }
                OrderItemsListBox.SelectedIndex = selectedIndex;
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count > 0)
            {
                _idCounter++;
                OrderItemsListBox.Items.Clear();
                AmountCostLabel.Text = "0";
                CreatedTextBox.Text = DateTime.Now.ToString();
                IdTextBox.Text = _idCounter.ToString();
                StatusComboBox.SelectedIndex = 0;
                DeliveryTimeComboBox.SelectedIndex = -1;

                PriorityOrder = new PriorityOrder();
                PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;
                DeliveryAddressControl.Address = new Address();
                DeliveryAddressControl.AddressClear();
                StatusComboBox.SelectedIndex = 0;
                DeliveryTimeComboBox.SelectedIndex = 0;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder.DesiredDeliveryTime = (DesiredDeliveryTime)DeliveryTimeComboBox.SelectedIndex;
        }

        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count == 0)
            {
                ClearOrderButton.Enabled = false;
                DeliveryAddressControl.Enabled = false;
                DeliveryAddressControl.AddressClear();
            }

            if (OrderItemsListBox.SelectedIndex == -1)
            {
                RemoveItemButton.Enabled = false;
                return;
            }

            DeliveryAddressControl.Address = PriorityOrder.Address;
            StatusComboBox.SelectedItem = PriorityOrder.OrderStatus;
            RemoveItemButton.Enabled = true;
        }
    }
}
