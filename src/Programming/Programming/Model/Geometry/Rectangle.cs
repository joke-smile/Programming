namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Создаёт экземпляр класс <see cref="Rectangle"/>
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класс <see cref="Rectangle"/>
        /// </summary>
        /// <param name="height">Высота прямоугольника. Значение должно быть положительным числом.</param>
        /// <param name="width">Ширина прямоугольника. Значение должно быть положительным числом.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Координаты центра прямоугольника.</param>
        public Rectangle(int height,
                         int width,
                         string color,
                         Point2D center)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задаёт координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает количество прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
        }

        /// <summary>
        /// Возвращает и задаёт высоту прямоугольника. Значение должно быть положительным числом.
        /// </summary>
        public int Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Height), value);
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Значение должно быть положительным числом.
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }
    }
}