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
        }

        private void DeparturePointTextBox_TextChanged(object sender, EventArgs e)
        {
            _current.DeparturePoint = DeparturePointTextBox.Text;
            UpdateFlightsListBox();
        }

        private void ClearTextBox()
        {
            DeparturePointTextBox.Clear();
            DestinationTextBox.Clear();
            FlightTypeComboBox.Text = "";
            FlightTimeTextBox.Clear();
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
            _current.Destination = DestinationTextBox.Text;
            UpdateFlightsListBox();
        }

        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FlightTimeTextBox.Text.Length == 0)
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
            _current.Type = (FlightType)FlightTypeComboBox.SelectedItem;
            UpdateFlightsListBox();
        }

        private void DepartureTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1)
            {
                return;
            }

            _current.DepartureData = DepartureTimeDateTimePicker.Value;

            //for (int i = 0; i < FlightsListBox.Items.Count; i++)
            //{
            //    for (int j = i; j < FlightsListBox.Items.Count; j++)
            //    {
            //        if (_listOfFlights[i].DepartureData < _listOfFlights[j].DepartureData)
            //        {
            //            List<FlightInfo> _tempList = new List<FlightInfo>();
            //            _tempList[0] = _listOfFlights[j];
            //            _listOfFlights[j] = _listOfFlights[i];
            //            _listOfFlights[i] = _tempList[0];
            //        }
            //    }
            //}

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
