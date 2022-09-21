using System;

namespace ListOfFlights.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
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
                throw new ArgumentException($"the value of the {nameProperty} field should " +
                    $"be between {min} and {max} (inclusive)");
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
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"the value of the {nameProperty} field should " +
                    $"be between {min} and {max} (inclusive)");
            }
        }

        public static void AssertData(DateTime selectedData)
        {
            if (selectedData < DateTime.Now.Date)
            { 
                throw new ArgumentException(
                    $"Некоректная дата.");
            }
        }
    }
}
