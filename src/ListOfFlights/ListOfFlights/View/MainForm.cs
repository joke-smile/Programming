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

namespace ListOfFlights
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Array typeValues = Enum.GetValues(typeof(FlightType));
            foreach (FlightType value in typeValues)
            {
                FlightTypeComboBox.Items.Add(value);
            }
            FlightTypeComboBox.SelectedIndex = 0;
        }

        private void DeparturePointTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            double time = double.Parse(FlightTimeTextBox.Text);
            Validator.AssertValueInRange(nameof(FlightTimeTextBox_TextChanged), time, 0, 1000);
        }
    }
}
