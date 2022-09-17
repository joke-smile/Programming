namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о контакте человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер контакта.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Конструктор по умолчанию.
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.
        /// Значение должно состоять только из букв английского алфавита.</param>
        /// 
        /// <param name="surname">Фамилия контакта.
        /// Значение должно состоять только из букв английского алфавита.</param>
        /// 
        /// <param name="number">Номер контакта.
        /// Значение должно состоять только из цифр.
        /// Должен иметь одиннадцать символов.</param>
        public Contact(string name,
                       string surname,
                       string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// Значение должно состоять только из букв английского алфавита.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Name), value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта.
        /// Значение должно состоять только из букв английского алфавита.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Surname), value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер контакта.
        /// Значение должно состоять только из цифр.
        /// Значение должно иметь только одиннадцать символов.
        /// </summary>
        public string Number
        {
            get => _number;
            set
            {
                Validator.AssertValueContainsOnlyDigits(nameof(Number), value);
                Validator.AssertNumberContainsOnlyElevenDigits(nameof(Number), value);
                _number = value;
            }
        }
    }
}