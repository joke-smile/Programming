using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Количество фильмов.
        /// </summary>
        private static int _allMoviesCount;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Уникальный идентификатор фильма.
        /// </summary>
        private int _id;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
            _allMoviesCount++;
            _id = _allMoviesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="releaseYear">Год выхода фильма. Значение должно быть в диапазоне от 1900 до нынешнего года (включительно).</param>
        /// <param name="durationMinutes">Продолжительность фильма в минутах. Значение должно быть положительным числом.</param>
        /// <param name="rating">Рейтинг фильма. Значение должно быть в диапазоне от 0 до 10 (включительно).</param>
        /// <param name="title">Название фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        public Movie(int releaseYear,
                    int durationMinutes,
                    int rating,
                    string title,
                    string genre)
        {
            ReleaseYear = releaseYear;
            DurationMinutes = durationMinutes;
            Rating = rating;
            Title = title;
            Genre = genre;
            _allMoviesCount++;
            _id = _allMoviesCount;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор фильма.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность фильма в минутах. Значение должно быть положительным числом.
        /// </summary>
        public int DurationMinutes
        {
            get => _durationMinutes;
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes), value);
                _durationMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год релиза фильма. Значение должно быть в диапазоне от 1900 до нынешнего года (включительно).
        /// </summary>
        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1990, DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Значение должно быть в диапазоне от 0 до 10 (включительно).
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0, 10);
                _rating = value;
            }
        }
    }
}
