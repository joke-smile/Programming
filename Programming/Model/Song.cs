namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _durationSeconds;

        /// <summary>
        /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="author">Имя автора.</param>
        /// <param name="name">Название песни.</param>
        /// <param name="durationSeconds">Продолжительность песни в секундах.
        /// Значение должно быть положительным числом.</param>
        public Song(string author,
                    string name,
                    int durationSeconds)
        {
            Author = author;
            Name = name;
            DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Возвращает и задаёт имя автора.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах.
        /// Значение должно быть положительным числом.
        /// </summary>
        public int DurationSeconds
        {
            get => _durationSeconds;
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationSeconds), value);
                _durationSeconds = value;
            }
        }
    }
}
