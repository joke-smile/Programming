using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создаёт экзампляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            DisabledCustomersTextBoxes();
        }

        /// <summary>
        /// Обновляет данные в списке CustomersListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Customer> customers = _customers;

            CustomersListBox.Items.Clear();

            foreach (var customer in customers)
            {
                if (customer.FullName != "Full Name")
                {
                    CustomersListBox.Items.Add(customer.FullName);
                }
                else
                {
                    CustomersListBox.Items.Add($"Customer {customer.Id}");
                }
            }

            if (-1 <= index && index < CustomersListBox.Items.Count)
            {
                CustomersListBox.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Включает поля для ввода пользователем.
        /// </summary>
        private void EnabledCustomersTextBoxes()
        {
            CustomerFullNameTextBox.Enabled = true;
            CustomerAddressTextBox.Enabled = true;
        }

        /// <summary>
        /// Отключает поля для ввода пользователем.
        /// </summary>
        private void DisabledCustomersTextBoxes()
        {
            CustomerFullNameTextBox.Enabled = false;
            CustomerAddressTextBox.Enabled = false;
        }

        /// <summary>
        /// Очищает поля для вывода информации о покупателе.
        /// </summary>
        private void ClearInfo()
        {
            CustomersListBox.SelectedIndex = -1;
            CustomerIdTextBox.Clear();
            CustomerFullNameTextBox.Clear();
            CustomerAddressTextBox.Clear();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            _customers.Add(customer);
            UpdateListBox(_customers.IndexOf(customer));
            EnabledCustomersTextBoxes();
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                DisabledCustomersTextBoxes();
                return;
            }

            _customers.RemoveAt(CustomersListBox.SelectedIndex);

            if (_customers.Count == 0)
            {
                DisabledCustomersTextBoxes();
                UpdateListBox(-1);
                ClearInfo();
            }
            else
            {
                UpdateListBox(0);
                EnabledCustomersTextBoxes();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            EnabledCustomersTextBoxes();
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            CustomerIdTextBox.Text = _currentCustomer.Id.ToString();
            CustomerFullNameTextBox.Text = _currentCustomer.FullName;
            CustomerAddressTextBox.Text = _currentCustomer.Address;
        }

        private void CustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.FullName = CustomerFullNameTextBox.Text;
                CustomerFullNameTextBox.BackColor = AppColors.CorrectColor;
                UpdateListBox(_customers.IndexOf(_currentCustomer));
            }
            catch
            {
                CustomerFullNameTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void CustomerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            try
            {
                _currentCustomer.Address = CustomerAddressTextBox.Text;
                CustomerAddressTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                CustomerAddressTextBox.BackColor = AppColors.ErrorColor;
            }
        }
    }
}
