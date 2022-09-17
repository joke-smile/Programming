using System;

namespace ObjectOrientedPractics.Model
{
    public class Validator
    {
        /// <summary>
        /// Проверка на то, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона (минимальное значение).</param>
        /// <param name="max">Правая граница диапазона (максимальное значение).</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если число находится вне диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string nameProperty)
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
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если число находится вне диапазона.</exception>
        public static void AssertValueInRange(double value, double min, double max, string nameProperty)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"the value of the {nameProperty} field should " +
                    $"be between {min} and {max} (inclusive)");
            }
        }
    }
}
