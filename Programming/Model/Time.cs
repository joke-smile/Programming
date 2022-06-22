namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Количество минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Количество секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Количество часов.
        /// Значение должно быть положительным числом.
        /// Значение должно быть в пределах от 0 до 23 (включительно).</param>
        /// <param name="minutes">Количество минут.
        /// Значение должно быть положительным числом.
        /// Значение должно быть в пределах от 0 до 59 (включительно).</param>
        /// <param name="seconds">Количество секунд.
        /// Значение должно быть положительным числом.
        /// Значение должно быть в пределах от 0 до 59 (включительно).</param>
        public Time(int hours,
                    int minutes,
                    int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Возвращает и задаёт количество часов.
        /// Значение должно быть положительным числом.
        /// Значение должно быть в пределах от 0 до 23 (включительно).
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertValueInRange(nameof(Hours), value, 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество минут.
        /// Значение должно быть положительным числом.
        /// Значение должно быть в пределах от 0 до 59 (включительно).
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(nameof(Minutes), value, 0, 59);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество секунд.
        /// Значение должно быть положительным числом. 
        /// Значение должно быть в пределах от 0 до 59 (включительно).
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(nameof(Seconds), value, 0, 59);
                _seconds = value;
            }
        }
    }
}
