namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о координатах центра фигуры.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Значение должно быть положительным числом.</param>
        /// <param name="y">Координата Y. Значение должно быть положительным числом.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задаёт координату Х. Значение должно быть положительным числом.
        /// </summary>
        public int X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт координату Y. Значение должно быть положительным числом.
        /// </summary>
        public int Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                _y = value;
            }
        }
    }
}
