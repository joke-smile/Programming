using System;

namespace ListOfFlights.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверка на то, что длина строки меньше 100 символов.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число. </param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// когда число меньше или равно нулю.</exception>
        public static void LimitOfLength(string nameProperty, int value)
        {
            if (value > 100)
            {
                throw new ArgumentException($"the value of the {nameProperty} field must be positive");
            }
        }

        /// <summary>
        /// Проверка на то, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона (минимальное значение).</param>
        /// <param name="max">Правая граница диапазона (максимальное значение).</param>
        /// <exception cref="System.ArgumentException">Выбрасывается,
        /// если число находится вне диапазона.</exception>
        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                        $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }
    }
}
