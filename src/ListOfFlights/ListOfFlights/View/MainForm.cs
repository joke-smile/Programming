using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListOfFlights.Model;
using FlightInfo = ListOfFlights.Model.FlightInfo;


namespace ListOfFlights.View
{
    public partial class MainForm : Form
    {
        private readonly List<FlightInfo> _listOfFlights = new List<FlightInfo>();
        private FlightInfo _current;

        public MainForm()
        {
            InitializeComponent();

            Array typeValues = Enum.GetValues(typeof(FlightType));
            foreach (FlightType value in typeValues)
            {
                FlightTypeComboBox.Items.Add(value);
            }
            DepartureTimeDateTimePicker.MinDate = DateTime.Now;
            DepartureTimeDateTimePicker.Enabled = false;
            FlightTimeTextBox.Enabled = false;
            DeparturePointTextBox.Enabled = false;
            DestinationTextBox.Enabled = false;
            FlightTypeComboBox.Enabled = false;
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            _current = new FlightInfo();

            _listOfFlights.Add(_current);
            FlightsListBox.Items.Add(_current.FlightDescription());
            FlightsListBox.SelectedIndex = _listOfFlights.Count - 1;
            ClearTextBox();
        }

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedItem == null) return;

            int index = FlightsListBox.SelectedIndex;
            _listOfFlights.RemoveAt(index);
            FlightsListBox.Items.RemoveAt(index);

            ClearTextBox();

            if (FlightsListBox.Items.Count == 0) return;
            FlightsListBox.SelectedIndex = 0;

            UpdateInformation(_current);
        }

        private void DeparturePointTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1 && DeparturePointTextBox.Text.Length > 0)
            {
                DeparturePointTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            else if (FlightsListBox.SelectedIndex == -1 && DeparturePointTextBox.Text.Length == 0)
            {
                DeparturePointTextBox.BackColor = AppColors.CorrectColor;
                return;
            }

            DeparturePointTextBox.BackColor = AppColors.CorrectColor;
            _current.DeparturePoint = DeparturePointTextBox.Text;
            UpdateFlightsListBox();
        }

        private void UpdateFlightsListBox()
        {
            int index = FlightsListBox.SelectedIndex;
            FlightsListBox.Items.Clear();
            
            foreach (var item in _listOfFlights)
            {
                FlightsListBox.Items.Add(item.FlightDescription());
            }
            FlightsListBox.SelectedIndex = index;
        }

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1 && DestinationTextBox.Text.Length > 0)
            {
                DestinationTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            else if (FlightsListBox.SelectedIndex == -1 && DestinationTextBox.Text.Length == 0)
            {
                DestinationTextBox.BackColor = AppColors.CorrectColor;
                return;
            }
            DestinationTextBox.BackColor = AppColors.CorrectColor;
            _current.Destination = DestinationTextBox.Text;
            UpdateFlightsListBox();
        }

        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1 && FlightTimeTextBox.Text.Length > 0)
            {
                FlightTimeTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            else if (FlightsListBox.SelectedIndex == -1 || FlightTimeTextBox.Text.Length == 0)
            {
                FlightTimeTextBox.BackColor = AppColors.CorrectColor;
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
            if (FlightsListBox.SelectedIndex == -1)
            {
                FlightTypeComboBox.BackColor = AppColors.ErrorColor;
                return;
            }

            try
            {
                FlightTypeComboBox.BackColor = AppColors.CorrectColor;
                _current.Type = (FlightType)FlightTypeComboBox.SelectedItem;
            }
            catch
            {
                FlightTypeComboBox.BackColor = AppColors.ErrorColor;
            }
        }

        private void ClearTextBox()
        {
            DeparturePointTextBox.Clear();
            DestinationTextBox.Clear();
            FlightTimeTextBox.Clear();
            FlightTypeComboBox.Text = "";
        }

        private void DepartureTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1)
            {
                DepartureTimeDateTimePicker.CalendarTrailingForeColor = AppColors.ErrorColor;
                return;
            }
            DepartureTimeDateTimePicker.CalendarTrailingForeColor = AppColors.CorrectColor;
            _current.DepartureData = DepartureTimeDateTimePicker.Value;
            UpdateFlightsListBox();
        }

        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1)
            {
                DepartureTimeDateTimePicker.Enabled = false;
                FlightTimeTextBox.Enabled = false;
                DeparturePointTextBox.Enabled = false;
                DestinationTextBox.Enabled = false;
                FlightTypeComboBox.Enabled = false;
                return;
            }
            DepartureTimeDateTimePicker.Enabled = true;
            FlightTimeTextBox.Enabled = true;
            DeparturePointTextBox.Enabled = true;
            DestinationTextBox.Enabled = true;
            FlightTypeComboBox.Enabled = true;

            _current = _listOfFlights[FlightsListBox.SelectedIndex];
            UpdateInformation(_current);
        }

        public void UpdateInformation(FlightInfo flight)
        {
            DeparturePointTextBox.Text = flight.DeparturePoint;
            DestinationTextBox.Text = flight.Destination;
            DepartureTimeDateTimePicker.Value = flight.DepartureData;
            FlightTimeTextBox.Text = Convert.ToString(flight.FlightTime);
            FlightTypeComboBox.SelectedItem = flight.Type;
        }
    }
}
