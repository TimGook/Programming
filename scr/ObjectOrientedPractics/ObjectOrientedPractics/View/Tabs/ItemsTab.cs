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
using ObjectOrientedPractics.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Категории товаров.
        /// </summary>
        object[] _categoryValues = Enum.GetValues(typeof(Category)).Cast<object>().ToArray();

        /// <summary>
        /// Список товаров при поиске.
        /// </summary>
        private List<Item> _displayedItems = new List<Item>();

        public ItemsTab()
        {
            InitializeComponent();

            ItemsListBox.DataSource = _itemsList;
            ClearItemsInfo();
            ItemsListBox.SelectedIndex = -1;

            ToggleInputBoxes(false);
            ApplyItemInfoChangesButton.Enabled = false;
            ApplyItemInfoChangesButton.Visible = false;

            CategoryComboBox.Items.AddRange(_categoryValues);
            CategoryComboBox.SelectedItem = _categoryValues[0];

            OrderByComboBox.Items.AddRange(new string[] { "Name", "Cost (Ascending)", "Cost (Descending)" });
            OrderByComboBox.SelectedIndex = 0;
            SortBy();
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

        ///// <summary>
        ///// Индекс текущего выбранного элемента для сортировки 
        ///// и сохранения выбранного элемента в ListBox.
        ///// </summary>
        //private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        internal List<Item> Items
        {
            get
            {
                return _itemsList;
            }
            set
            {
                _itemsList = value;
                SortBy();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                if (_displayedItems.Count != 0)
                {
                    ToggleInputBoxes(false);
                    _clonedCurrentItem = (Item)_displayedItems[ItemsListBox.SelectedIndex].Clone();
                    ItemNameTextBox.Text = _clonedCurrentItem.Name;
                    ItemCostTextBox.Text = _clonedCurrentItem.Cost.ToString();
                    ItemDescriptionTextBox.Text = _clonedCurrentItem.Info;
                    ItemIdTextBox.Text = _clonedCurrentItem.Id.ToString();
                    CategoryComboBox.SelectedItem = _clonedCurrentItem.Category;
                }

                else
                {
                    ToggleInputBoxes(false);
                    _clonedCurrentItem = (Item)_itemsList[ItemsListBox.SelectedIndex].Clone();
                    ItemNameTextBox.Text = _clonedCurrentItem.Name;
                    ItemDescriptionTextBox.Text = _clonedCurrentItem.Info;
                    ItemCostTextBox.Text = _clonedCurrentItem.Cost.ToString();
                    ItemIdTextBox.Text = _clonedCurrentItem.Id.ToString();
                    CategoryComboBox.SelectedItem = _clonedCurrentItem.Category;
                    EditItemButton.Enabled = true;
                    //ApplyItemInfoChangesButton.Enabled = false;
                    //ApplyItemInfoChangesButton.Visible = false;
                }
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
            _currentItem = (Item)ItemsListBox.SelectedItem;
            _itemsList.Remove(_currentItem);
            ItemsListBox.SelectedIndex = -1;
            SortBy();
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
            _clonedCurrentItem = (Item)ItemsListBox.SelectedItem;
            _clonedCurrentItem = (Item)_clonedCurrentItem.Clone();
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
                    SortBy();
                }
                else
                {
                    _itemsList[Items.IndexOf((Item)ItemsListBox.SelectedItem)] = _clonedCurrentItem;
                    _currentItem = _clonedCurrentItem;
                }

                _displayedItems = new List<Item>();
                FindItemTextBox.Text = string.Empty;
                DataTools.FilterNamePrincipleOfVerification = string.Empty;
                SortBy();
                UpdateItemsInfo();
                ToggleInputBoxes(false);
                ClearItemsInfo();
                ApplyItemInfoChangesButton.Enabled = false;
                ApplyItemInfoChangesButton.Visible = false;
                ItemErrorsLabel.Visible = false;
                ItemsListBox.SelectedIndex = -1;
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
        /// Метод для сортировки товаров в зависимости от выбранного значения.
        /// </summary>
        private void SortBy()
        {
            var testSelectedItem = ItemsListBox.SelectedItem;
            ItemsListBox.DataSource = null;
            if (OrderByComboBox.SelectedIndex == 0)
            {
                CompareValues compare = DataTools.CompareName;
                _itemsList = DataTools.Sort(_itemsList, compare);
                _displayedItems = DataTools.Sort(_displayedItems, compare);
            }

            else if (OrderByComboBox.SelectedIndex == 1)
            {
                CompareValues compare = DataTools.CompareAscending;
                _itemsList = DataTools.Sort(_itemsList, compare);
                _displayedItems = DataTools.Sort(_displayedItems, compare);
            }

            else if (OrderByComboBox.SelectedIndex == 2)
            {
                CompareValues compare = DataTools.CompareDescending;
                _itemsList = DataTools.Sort(_itemsList, compare);
                _displayedItems = DataTools.Sort(_displayedItems, compare);
            }

            if (!string.IsNullOrEmpty(FindItemTextBox.Text))
            {
                _displayedItems = DataTools.ItemsFiltred(_displayedItems, DataTools.ItemFilterByName);
                ItemsListBox.SelectedIndexChanged -= ItemsListBox_SelectedIndexChanged;
                ItemsListBox.DataSource = _displayedItems;
                ItemsListBox.SelectedIndex = -1;
                ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            }

            else
            {
                FindItemTextBox.Text = string.Empty;
                ItemsListBox.DataSource = _itemsList;
            }
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
            ApplyItemInfoChangesButton.Enabled = true;
            ApplyItemInfoChangesButton.Visible = true;
            ItemErrorsLabel.Visible = false;
            ItemNameTextBox.BackColor = Color.White;
            ItemCostTextBox.BackColor = Color.White;
            ItemDescriptionTextBox.BackColor = Color.White;
        }

        private void FindItemTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTools.FilterNamePrincipleOfVerification = FindItemTextBox.Text;

            ClearItemsInfo();

            if (!string.IsNullOrEmpty(FindItemTextBox.Text))
            {
                _displayedItems = DataTools.ItemsFiltred(_itemsList, DataTools.ItemFilterByName);
                ItemsListBox.DataSource = _displayedItems;
            }

            else
            {
                ItemsListBox.DataSource = _itemsList;
                SortBy();
                _displayedItems = new List<Item>();
                FindItemTextBox.Text = string.Empty;
            }
        }

        private void SortItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortBy();
        }
    }
}
