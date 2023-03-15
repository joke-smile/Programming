using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллеция товаров.
        /// </summary>
        List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создаёт экзампляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            DisabledItemsTextBoxes();
        }

        /// <summary>
        /// Обновляет данные в списке ItemsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Item> items = _items;

            ItemsListBox.Items.Clear();

            foreach (var item in items)
            {
                if (item.Name != "Item")
                {
                    ItemsListBox.Items.Add(item.Name);
                }
                else
                {
                    ItemsListBox.Items.Add($"Item {item.Id}");
                }
            }

            if (-1 <= index && index < ItemsListBox.Items.Count)
            {
                ItemsListBox.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Включает поля для ввода пользователем.
        /// </summary>
        private void EnabledItemsTextBoxes()
        {
            ItemCostTextBox.Enabled = true;
            ItemNameTextBox.Enabled = true;
            ItemInfoTextBox.Enabled = true;
        }

        /// <summary>
        /// Отключает поля для ввода пользователем.
        /// </summary>
        private void DisabledItemsTextBoxes()
        {
            ItemCostTextBox.Enabled = false;
            ItemNameTextBox.Enabled = false;
            ItemInfoTextBox.Enabled = false;
        }

        /// <summary>
        /// Очищает поля для вывода информации о товаре.
        /// </summary>
        private void ClearInfo()
        {
            ItemsListBox.SelectedIndex = -1;
            ItemIdTextBox.Clear();
            ItemCostTextBox.Clear();
            ItemNameTextBox.Clear();
            ItemInfoTextBox.Clear();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var item = new Item();
            _items.Add(item);
            UpdateListBox(_items.IndexOf(item));
            EnabledItemsTextBoxes();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            _items.RemoveAt(ItemsListBox.SelectedIndex);

            if (_items.Count == 0)
            {
                DisabledItemsTextBoxes();
                UpdateListBox(-1);
                ClearInfo();
            }
            else
            {
                UpdateListBox(0);
                EnabledItemsTextBoxes();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;


            EnabledItemsTextBoxes();
            _currentItem = _items[ItemsListBox.SelectedIndex];
            ItemIdTextBox.Text = _currentItem.Id.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name;
            ItemInfoTextBox.Text = _currentItem.Info;
        }

        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Cost = double.Parse(ItemCostTextBox.Text);
                ItemCostTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                ItemCostTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Name = ItemNameTextBox.Text;
                ItemNameTextBox.BackColor = AppColors.CorrectColor;
                UpdateListBox(_items.IndexOf(_currentItem));
            }
            catch
            {
                ItemNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ItemInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            try
            {
                _currentItem.Info = ItemInfoTextBox.Text;
                ItemInfoTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                ItemInfoTextBox.BackColor = AppColors.ErrorColor;
            }
        }
    }
}
