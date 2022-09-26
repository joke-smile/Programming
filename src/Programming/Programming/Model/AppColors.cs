using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о вызываемых цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static Color CorrectColor = Color.White;

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет пересекающейся фигуры.
        /// </summary>
        public static Color InContact = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет непересекающейся фигуры.
        /// </summary>
        public static Color NonContact = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет при выборе Winter в списке времен года.
        /// </summary>
        public static Color Winter = Color.White;

        /// <summary>
        /// Цвет при выборе Spring в списке времен года.
        /// </summary>
        public static Color Spring = Color.FromArgb(226, 215, 69);

        /// <summary>
        /// Цвет при выборе Summer в списке времен года.
        /// </summary>
        public static Color Summer = Color.FromArgb(88, 214, 49);

        /// <summary>
        /// Цвет при выборе Autumn в списке времен года.
        /// </summary>
        public static Color Autumn = Color.FromArgb(226, 156, 69);
    }
}
