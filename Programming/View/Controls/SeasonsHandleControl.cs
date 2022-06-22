using System;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация изменения цвета фона главного окна.
    /// </summary>
    public partial class SeasonsHandleControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonsHandleControl"/>.
        /// </summary>
        public SeasonsHandleControl()
        {
            InitializeComponent();

            Array seasons = Enum.GetValues(typeof(Seasons));
            foreach (Seasons value in seasons)
            {
                SeasonsComboBox.Items.Add(value);
            }
            SeasonsComboBox.SelectedIndex = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedItem)
            {
                case Seasons.Winter:
                    this.BackColor = AppColors.Winter;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Seasons.Spring:
                    this.BackColor = AppColors.Spring;
                    MessageBox.Show("Ура! Тепло!");
                    break;
                case Seasons.Summer:
                    this.BackColor = AppColors.Summer;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    this.BackColor = AppColors.Autumn;
                    MessageBox.Show("Не люблю осень!");
                    break;
            }
        }
    }
}
