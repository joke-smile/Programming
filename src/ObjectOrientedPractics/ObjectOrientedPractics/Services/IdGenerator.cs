namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет метод для генерации уникального идентификатора.
    /// </summary>
    public class IdGenerator
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        private static int _id = 0;

        /// <summary>
        /// Метод для генерации уникального идентификатора.
        /// </summary>
        /// <returns>Возвращает уникальный идентификатор.</returns>
        public static int GetId()
        {
            return _id++;
        }
    }
}
