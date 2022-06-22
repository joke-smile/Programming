using System;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверка на то, что число является положительным.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число. </param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"the value of the {nameProperty} field must be positive");
            }
        }

        /// <summary>
        /// Проверка на то, что число является положительным.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
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
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                        $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
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

        /// <summary>
        /// Проверка на то, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если строка состоит не только из букв английского алфавита.</exception>
        public static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should consist only of English letters.");
            }
        }

        /// <summary>
        /// Проверка на то, что строка состоит только из цифр.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если строка состоит не только из цифр.</exception>
        public static void AssertValueContainsOnlyDigits(string nameProperty, string value)
        {
            if (!long.TryParse(value, out long number))
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must consist of digits only");
            }
        }

        /// <summary>
        /// Проверяет, что в строке только 11 символов.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если в строке не 11 символов.</exception>
        public static void AssertNumberContainsOnlyElevenDigits(string nameProperty, string value)
        {
            if (value.Length != 11)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must consist of 11 digits");
            }
        }
    }
}
