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
//using ObjectOrientedPractics.ClassesSerialization;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        //Категории товара.
        object[] _categoryValues = Enum.GetValues(typeof(Category)).Cast<object>().ToArray();

        public ItemsTab()
        {
            InitializeComponent();
            //_itemsList = ItemsSerializer.LoadItems();
            ItemsListBox.DataSource = _itemsList;
            ClearItemsInfo();
            ItemsListBox.SelectedIndex = -1;
            ToggleInputBoxes(false);
            ApplyItemInfoChangesButton.Enabled = false;
            ApplyItemInfoChangesButton.Visible = false;

            CategoryComboBox.Items.AddRange(_categoryValues);
            CategoryComboBox.SelectedItem = _categoryValues[0];
            //CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            //CategoryComboBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Правильность ввода название товара.
        /// </summary>
        private bool IsValidItemName = true;

        /// <summary>
        /// Правильность ввода информации о товаре.
        /// </summary>
        private bool IsValidItemInfo = true;

        /// <summary>
        /// Правильность ввода стоимости товара.
        /// </summary>
        private bool IsValidItemCost = true;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _itemsList = new List<Item>();

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Копия выбранного товара.
        /// </summary>
        private Item _clonedCurrentItem = new Item();

        /// <summary>
        /// Индекс текущего выбранного элемента для сортировки 
        /// и сохранения выбранного элемента в ListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _clonedCurrentItem = (Item)_itemsList[ItemsListBox.SelectedIndex].Clone();
                ItemNameTextBox.Text = _clonedCurrentItem.Name;
                ItemDescriptionTextBox.Text = _clonedCurrentItem.Info;
                ItemCostTextBox.Text = _clonedCurrentItem.Cost.ToString();
                ItemIdTextBox.Text = _clonedCurrentItem.Id.ToString();
                CategoryComboBox.SelectedItem = _clonedCurrentItem.Category;
                EditItemButton.Enabled = true;
                ApplyItemInfoChangesButton.Enabled = false;
                ApplyItemInfoChangesButton.Visible = false;
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ClearItemsInfo();
            ItemsListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
            EditItemButton.Enabled = false;
            ApplyItemInfoChangesButton.Enabled = true;
            ApplyItemInfoChangesButton.Visible = true;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentItem = _itemsList[ItemsListBox.SelectedIndex];
            _itemsList.Remove(_currentItem);
            ItemsListBox.SelectedIndex = -1;
            //ItemsSerializer.Save(_itemsList);
            Sort();
            ClearItemsInfo();
            EditItemButton.Enabled = false;
            ApplyItemInfoChangesButton.Enabled = false;
            ApplyItemInfoChangesButton.Visible = false;
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = ItemsListBox.SelectedIndex;
            _clonedCurrentItem = (Item)_itemsList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
            ApplyItemInfoChangesButton.Enabled = true;
            ApplyItemInfoChangesButton.Visible = true;
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ItemNameTextBox.Text))
                {
                    _clonedCurrentItem.Name = ItemNameTextBox.Text;
                    ItemNameTextBox.BackColor = Color.White;
                    IsValidItemName = true;
                    ItemErrorsLabel.Visible = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidItemName = false;
                ItemNameTextBox.BackColor = Color.LightPink;
                ItemErrorsLabel.Text = "Необходимо указать название товара.";
                ItemErrorsLabel.Visible = true;
                CheckData();
            }
            catch (FormatException)
            {
                IsValidItemName = false;
                ItemNameTextBox.BackColor = Color.LightPink;
                ItemErrorsLabel.Text = "Необходимо указать название товара.";
                ItemErrorsLabel.Visible = true;
                CheckData();
            }
        }

        private void ItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ItemDescriptionTextBox.Text))
                {
                    _clonedCurrentItem.Info = ItemDescriptionTextBox.Text;
                    ItemDescriptionTextBox.BackColor = Color.White;
                    IsValidItemInfo = true;
                    ItemErrorsLabel.Visible = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidItemInfo = false;
                ItemDescriptionTextBox.BackColor = Color.LightPink;
                ItemErrorsLabel.Text = "Необходимо добавить описание товара.";
                ItemErrorsLabel.Visible = true;
                CheckData();
            }
            catch (FormatException)
            {
                IsValidItemInfo = false;
                ItemDescriptionTextBox.BackColor = Color.LightPink;
                ItemErrorsLabel.Text = "Необходимо добавить описание товара.";
                ItemErrorsLabel.Visible = true;
                CheckData();
            }
        }

        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ItemCostTextBox.Text))
                {
                    _clonedCurrentItem.Cost = Int32.Parse(ItemCostTextBox.Text);
                    ItemCostTextBox.BackColor = Color.White;
                    IsValidItemCost = true;
                    ItemErrorsLabel.Visible = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                IsValidItemCost = false;
                ItemCostTextBox.BackColor = Color.LightPink;
                ItemErrorsLabel.Text = "Необходимо указать цену(числом), не превышающим 100000.";
                ItemErrorsLabel.Visible = true;
                CheckData();
            }
            catch (FormatException)
            {
                IsValidItemCost = false;
                ItemCostTextBox.BackColor = Color.LightPink;
                ItemErrorsLabel.Text = "Необходимо указать цену(числом), не превышающим 100000.";
                ItemErrorsLabel.Visible = true;
                CheckData();
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedIndex != -1)
            {
                try
                {
                    if (!string.IsNullOrEmpty(CategoryComboBox.Text))
                    {
                        _clonedCurrentItem.Category = (Category)CategoryComboBox.SelectedItem;
                        CategoryComboBox.BackColor = Color.White;
                    }
                }
                catch (ArgumentException)
                {
                    CategoryComboBox.BackColor = Color.LightPink;
                }
            }


            //_clonedCurrentItem.Category = (Category)CategoryComboBox.SelectedItem;
        }

        private void ApplyItemInfoChangesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemNameTextBox.Text) ||
                string.IsNullOrEmpty(ItemDescriptionTextBox.Text) ||
                string.IsNullOrEmpty(ItemCostTextBox.Text))
            {
                ItemErrorsLabel.Text = "Необходимо заполнить все поля.";
                ItemErrorsLabel.Visible = true;
            }
            else
            {
                if (_selectedIndex == -1)
                {
                    _currentItem = new Item(
                        ItemNameTextBox.Text,
                        ItemDescriptionTextBox.Text,
                        Int32.Parse(ItemCostTextBox.Text),
                        (Category)CategoryComboBox.SelectedItem);
                    _itemsList.Add(_currentItem);
                    Sort();
                    //ItemsSerializer.Save(_itemsList);
                }
                else
                {
                    _itemsList[_selectedIndex] = _clonedCurrentItem;
                    _currentItem = _clonedCurrentItem;
                }

                Sort();
                UpdateItemsInfo();
                //ItemsSerializer.Save(_itemsList);
                ToggleInputBoxes(false);
                ClearItemsInfo();
                ApplyItemInfoChangesButton.Enabled = false;
                ApplyItemInfoChangesButton.Visible = false;
                ItemErrorsLabel.Visible = false;
                ItemsListBox.SelectedIndex = -1;
                //CategoryComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Метод, проверяющий значения текстовых полей и не дающий их сохранить в случае неправильного ввода.
        /// </summary>
        private void CheckData()
        {
            if (IsValidItemName && IsValidItemCost && IsValidItemInfo)
            {
                ApplyItemInfoChangesButton.Enabled = true;
                ApplyItemInfoChangesButton.Visible = true;
            }
            else
            {
                ApplyItemInfoChangesButton.Enabled = false;
                ApplyItemInfoChangesButton.Visible = false;
            }
        }

        /// <summary>
        /// Метод, который включает или отключает все элементы.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            ItemNameTextBox.Enabled = value;
            ItemCostTextBox.Enabled = value;
            ItemDescriptionTextBox.Enabled = value;
            CategoryComboBox.Enabled = value;
        }

        /// <summary>
        /// Метод, который обновляет данные выбранного товара в TextBox и ComboBox.
        /// </summary>
        private void UpdateItemsInfo()
        {
            ItemNameTextBox.Text = _currentItem.Name;
            ItemDescriptionTextBox.Text = _currentItem.Info;
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemIdTextBox.Text = _currentItem.Id.ToString();
            CategoryComboBox.SelectedItem = _currentItem.Category;
        }

        /// <summary>
        /// Метод, который сортирует <see cref="_itemsList"/> и <see cref="ItemsListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = ItemsListBox.SelectedIndex;
            ItemsListBox.SelectedIndexChanged -= ItemsListBox_SelectedIndexChanged;
            _itemsList = _itemsList.OrderBy(item => item.Name).ToList();
            ItemsListBox.DataSource = _itemsList;
            ItemsListBox.SelectedIndex = _indexBeforeSort;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод, который очищает текстовые поля и ComboBox.
        /// </summary>
        private void ClearItemsInfo()
        {
            ItemNameTextBox.Clear();
            ItemDescriptionTextBox.Clear();
            ItemCostTextBox.Clear();
            ItemIdTextBox.Clear();
            //CategoryComboBox.SelectedItem = _categoryValues[0];
            ApplyItemInfoChangesButton.Enabled = true;
            ApplyItemInfoChangesButton.Visible = true;
            ItemErrorsLabel.Visible = false;
            ItemNameTextBox.BackColor = Color.White;
            ItemCostTextBox.BackColor = Color.White;
            ItemDescriptionTextBox.BackColor = Color.White;
        }
    }
}
