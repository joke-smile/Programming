using static ObjectOrientedPractics.Services.IdGenerator;
using ObjectOrientedPractics.Services;
namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит информацию о потребителе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Хранит уникальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя.
        /// Должно содержать до 200 символов (включительно).
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки покупателя.
        /// Должно содержать до 500 символов (включительно).
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.
        /// Должно содержать от 1 до 200 символов.</param>
        /// <param name="address">Адрес доставки покупателя.
        /// Должен содержать от 1 до 500 символов.</param>
        public Customer(string fullname, string address)
        {
            _id = GetId();
            FullName = fullname;
            Address = address;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = GetId();
            FullName = "fullname";
            Address = "address";
        }

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int Id { get { return _id; } }
    }
}
