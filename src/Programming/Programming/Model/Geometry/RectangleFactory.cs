using Programming.Model.Enums;
using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Предоставляет методы для создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Отступ внутри панели с размещением прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Минимальная ширина
        /// </summary>
        private const int MinWidth = 30;

        /// <summary>
        /// Максимальная ширина
        /// </summary>
        private const int MaxWidth = 101;

        /// <summary>
        /// Минимальная высота
        /// </summary>
        private const int MinHeight = 30;

        /// <summary>
        /// Максимальная высота
        /// </summary>
        private const int MaxHeight = 101;

        /// <summary>
        /// Генерация случайных значений.
        /// </summary>
        private static Random _random;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectangleFactory"/>.
        /// </summary>
        static RectangleFactory()
        {
            _random = new Random();
        }

        /// <summary>
        /// Создание прямоугольника со случайными значениями ширины, высоты и координат.
        /// </summary>
        /// <param name="widthCanvas">Ширина элемента размещения.</param>
        /// <param name="heightCanvas">Высота элемента размещения.</param>
        /// <returns>Возвращает объект Rectangle.</returns>
        public static Rectangle Randomize(int widthCanvas, int heightCanvas)
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(MinWidth, MaxWidth);
            rectangle.Height = _random.Next(MinHeight, MaxHeight);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width - Margin),
                                           _random.Next(Margin, heightCanvas - rectangle.Height - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}