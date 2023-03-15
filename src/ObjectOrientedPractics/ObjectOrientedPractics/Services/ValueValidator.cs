using System;
namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Содержит методы для проверки значений.
    /// </summary>
    public class ValueValidator
    {
        /// <summary>
        /// Проверка на то, что длина строки меньше определённого значения.
        /// </summary>
        /// <param name="value">Длина строки.</param>
        /// <param name="maxLength">Максимально допустимая длина</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если длина выше допустимой</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} " +
                    $"должен быть меньше {maxLength} символов");
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
        public static void AssertValueInRange(double value, double min, double max,
            string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"the value of the {propertyName} field should " +
                    $"be between {min} and {max} (inclusive)");
            }
        }
    }
}
