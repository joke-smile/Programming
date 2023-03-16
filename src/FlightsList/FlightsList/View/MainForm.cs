using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FlightsList.Model;
using FlightsList.Model.Enums;

namespace FlightsList.View
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция рейсов.
        /// </summary>
        private List<FlightInfo> _flightsList = new List<FlightInfo>();

        /// <summary>
        /// Текущий рейс.
        /// </summary>
        private FlightInfo _current;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            SwitchMode(false);

            Array typeValues = Enum.GetValues(typeof(FlightType));
            foreach (FlightType value in typeValues)
            {
                FlightTypeComboBox.Items.Add(value);
            }

            DepartureTimeDateTimePicker.MinDate = DateTime.Now;

            _flightsList = Serializer.Deserialize();

            for (int i = 0; i < _flightsList.Count;)
            {
                if (_flightsList[i].DepartureDate < DateTime.Now)
                {
                    _flightsList.RemoveAt(i);
                }
                else
                {
                    break;
                }
            }
            UpdateListBox(-1);
        }

        /// <summary>
        /// Обновляет данные в списке FlightsListBox.
        /// </summary>
        /// <param name="index">Индекс выбранного элемента.</param>
        private void UpdateListBox(int index)
        {
            FlightsListBox.Items.Clear();

            foreach (var item in _flightsList)
            {
                FlightsListBox.Items.Add(item.FlightDescription());
            }
            if (_flightsList.Count == 0) return;
            FlightsListBox.SelectedIndex = index;
        }

        /// <summary>
        /// Сортировка _flightsList.
        /// </summary>
        private void SortFlights()
        {
            _flightsList = (from flight in _flightsList
                              orderby flight.DepartureDate
                              select flight).ToList();
            UpdateListBox(-1);
        }

        /// <summary>
        /// Очищает поля для вывода информации о рейсе.
        /// </summary>
        private void ClearInfo()
        {
            DeparturePointTextBox.Clear();
            DestinationTextBox.Clear();
            FlightTimeTextBox.Clear();
            FlightTypeComboBox.SelectedIndex = -1;
            DepartureTimeDateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Отвечает за включение/отключение всей правой панели.
        /// </summary>
        /// <param name="value">True или false.</param>
        private void SwitchMode(bool value)
        {
            DepartureTimeDateTimePicker.Enabled = value;
            FlightTimeTextBox.Enabled = value;
            DeparturePointTextBox.Enabled = value;
            DestinationTextBox.Enabled = value;
            FlightTypeComboBox.Enabled = value;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            _current = new FlightInfo();

            _flightsList.Add(_current);
            UpdateListBox(_flightsList.Count - 1);
        }

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1) return;

            _flightsList.RemoveAt(FlightsListBox.SelectedIndex);

            if (_flightsList.Count == 0)
            {
                SwitchMode(false);
                UpdateListBox(-1);
                ClearInfo();
            }
            else
            {
                UpdateListBox(0);
            }

        }

        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1)
            {
                SwitchMode(false);
                return;
            }
            SwitchMode(true);

            _current = _flightsList[FlightsListBox.SelectedIndex];
            UpdateInformation(_current);
        }

        private void DeparturePointTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _current.DeparturePoint = DeparturePointTextBox.Text;
                DeparturePointTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                DeparturePointTextBox.BackColor = AppColors.ErrorColor;
            }
            UpdateListBox(_flightsList.IndexOf(_current));
        }

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _current.Destination = DestinationTextBox.Text;
                DeparturePointTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                DeparturePointTextBox.BackColor = AppColors.ErrorColor;
            }
            UpdateListBox(_flightsList.IndexOf(_current));
        }

        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FlightTimeTextBox.Text.Length == 0)
            {
                FlightTimeTextBox.BackColor = AppColors.CorrectColor;
                _current.FlightTime = 0;
                return;
            }

            try
            {
                _current.FlightTime = double.Parse(FlightTimeTextBox.Text);
                FlightTimeTextBox.BackColor = AppColors.CorrectColor;
            }
            catch
            {
                FlightTimeTextBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void FlightTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1) return;
            _current.Type = (FlightType)FlightTypeComboBox.SelectedItem;
        }

        private void DepartureTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1)
            {
                return;
            }

            _current.DepartureDate = DepartureTimeDateTimePicker.Value;
            SortFlights();
            UpdateListBox(_flightsList.IndexOf(_current));
        }

        public void UpdateInformation(FlightInfo flight)
        {
            DeparturePointTextBox.Text = flight.DeparturePoint;
            DestinationTextBox.Text = flight.Destination;
            DepartureTimeDateTimePicker.Value = flight.DepartureDate;
            if (flight.FlightTime != 0)
            {
                FlightTimeTextBox.Text = Convert.ToString(flight.FlightTime);
            }
            else
            {
                FlightTimeTextBox.Text = "";
            }
            FlightTypeComboBox.SelectedItem = flight.Type;
        }

        private void FlightTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            Array typeValues = Enum.GetValues(typeof(FlightType));
            foreach (var typeValue in typeValues)
            {
                if (Convert.ToString(typeValue) == FlightTypeComboBox.Text)
                {
                    _current.Type = (FlightType)typeValue;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.Serialize(_flightsList);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_24x24_black;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_24x24;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_24x24;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_24x24_black;
        }
    }
}
