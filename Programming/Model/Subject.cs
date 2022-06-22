namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Конструктор по умолчанию. Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="examDate">Дата экзамена по дисциплине.</param>
        /// <param name="mark">Оценка по дисциплине.
        /// Значение должно быть в диапазоне от 2 до 5 (включительно).</param>
        public Subject(string name,
                          string examDate,
                          int mark)
        {
            Name = name;
            ExamDate = examDate;
            Mark = mark;
        }

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата экзамена по дисциплине.
        /// </summary>
        public string ExamDate { get; set; }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине.
        /// Значение должно быть в диапазоне от 2 до 5 (включительно).
        /// </summary>
        public int Mark
        {
            get => _mark;
            set
            {
                Validator.AssertValueInRange(nameof(Mark), value, 2, 5);
                _mark = value;
            }
        }
    }
}