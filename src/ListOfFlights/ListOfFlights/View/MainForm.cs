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
        private List<FlightInfo> _listOfFlights = new List<FlightInfo>();
        private FlightInfo _current;

        public MainForm()
        {
            InitializeComponent();

            Array typeValues = Enum.GetValues(typeof(FlightType));
            foreach (FlightType value in typeValues)
            {
                FlightTypeComboBox.Items.Add(value);
            }
            
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            _current = new FlightInfo();

            _listOfFlights.Add(_current);
            FlightsListBox.Items.Add(_current.FlightDescription());
            ClearTextBox();

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
            _current.DeparturePoint = DeparturePointTextBox.Text;
            UpdateFlightsListBox();

        }

        private void UpdateFlightsListBox()
        {
            FlightsListBox.Items.Clear();
            
            foreach (var item in _listOfFlights)
            {
                FlightsListBox.Items.Add(item.FlightDescription());
            }
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

            _current.FlightTime = double.Parse(FlightTimeTextBox.Text);
        }

        private void FlightTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightTypeComboBox.SelectedItem == null) return;

            _current.Type = (FlightType)FlightTypeComboBox.SelectedItem;
        }

        private void ClearTextBox()
        {
            DeparturePointTextBox.Clear();
            DestinationTextBox.Clear();
            FlightTimeTextBox.Clear();
        }

        private void DepartureTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _current.DepartureData = DepartureTimeDateTimePicker.Value.Date;
            UpdateFlightsListBox();
        }

        private void FlightsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightsListBox.SelectedIndex == -1) return;

            _current = _listOfFlights[FlightsListBox.SelectedIndex];
            UpdateInformation(_current);
        }

        public void UpdateInformation(FlightInfo flight)
        {
            //это я написал, чтобы с элемента не сбрасывалось выделение при добавлении и удалении.
            int index = FlightsListBox.SelectedIndex;
            //
            DeparturePointTextBox.Text = flight.DeparturePoint;
            DestinationTextBox.Text = flight.Destination;
            DepartureTimeDateTimePicker.Value = flight.DepartureData;
            FlightTimeTextBox.Text = Convert.ToString(flight.FlightTime);
            FlightTypeComboBox.SelectedItem = flight.Type;
            //
            FlightsListBox.SelectedIndex = index;

        }
    }
}
