using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация представления перечислений.
    /// </summary>
    public partial class EnumerationControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="EnumerationControl"/>.
        /// </summary>
        public EnumerationControl()
        {
            InitializeComponent();

            Array typeValues = Enum.GetValues(typeof(Enums));
            foreach (Enums value in typeValues)
            {
                EnumsListBox.Items.Add(value);
            }
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enumValues;

            switch ((Enums)EnumsListBox.SelectedItem)
            {
                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;

                case Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;

                case Enums.Colors:
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;

                case Enums.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm));
                    break;

                case Enums.Smartphones:
                    enumValues = Enum.GetValues(typeof(Smartphones));
                    break;

                case Enums.Seasons:
                    enumValues = Enum.GetValues(typeof(Seasons));
                    break;

                default:
                    throw new NotImplementedException();
            }
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }
        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null) return;

            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
    }
}
