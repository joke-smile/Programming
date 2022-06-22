using System;
using Programming.Model.Geometry;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация представления прямоугольников, генерируемых программой.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int ElementsCount = 5;

        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();
            RectangleListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Создаёт коллекцию прямоугольников.
        /// </summary>
        /// <returns>Возвращает коллекцию прямоугольников.</returns>
        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[ElementsCount];
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = RectangleFactory.Randomize(300,300);
                rectangles[i] = _currentRectangle;
                RectangleListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        /// <summary>
        /// Находит прямоугольник с наибольшей шириной.
        /// </summary>
        /// <param name="rectangles">Прямоугольник.</param>
        /// <returns>Индекс элемента коллекции с наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            var maxWidthIndex = 0;
            var max = 0;

            for (int i = 0; i < ElementsCount; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void HeightRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;

            try
            {
                string currentLength = RectangleHeightTextBox.Text;
                int heightRectangle = int.Parse(currentLength);
                _currentRectangle.Height = heightRectangle;
            }
            catch
            {
                RectangleHeightTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleHeightTextBox.BackColor = AppColors.CorrectColor;
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1) return;

            try
            {
                string currentWidthRectangle = RectangleWidthTextBox.Text;
                int widthRectangle = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangle;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleWidthTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangle = RectangleColorTextBox.Text;
            _currentRectangle.Color = colorRectangle;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            if (RectangleListBox.SelectedIndex == -1) return;
            RectangleListBox.SelectedIndex = findMaxWidthIndex;
        }
    }
}
