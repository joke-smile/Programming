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


namespace ListOfFlights.View
{
    public partial class MainForm : Form
    {
        private List<FlightInfo> _listOfFlights = new List<FlightInfo>();
        private FlightInfo _current;

        public MainForm()
        {
            InitializeComponent();
            //DepartureTimeDateTimePicker.MinDate = DateTime.Now;
            

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


        }
        private void RemoveButtonClick(object sender, EventArgs e)
        {

        }
        private void DeparturePointTextBox_TextChanged(object sender, EventArgs e)
        {
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
            _current.Destination = DestinationTextBox.Text;
            UpdateFlightsListBox();
        }

        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            _current.FlightTime = double.Parse(FlightTimeTextBox.Text);
        }

        private void FlightTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightTypeComboBox.SelectedItem == null) return;
            _current.Type = (FlightType)FlightTypeComboBox.SelectedItem;
        }

        private void DepartureTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _current.DepartureData = DepartureTimeDateTimePicker.Value;
            UpdateFlightsListBox();
        }
    }
}
