using static ObjectOrientedPractics.Services.IdGenerator;
using static ObjectOrientedPractics.Services.ValueValidator;
namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Содержит информацию о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Хранит уникальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара.
        /// Должно содержать от 1 до 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара.
        /// Должен содержать от 0 до 100 000 символов.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара.
        /// Должно содержать от 1 до 200 символов.</param>
        /// <param name="info">Описание товара.
        /// Должно содержать от 1 до 1000 символов</param>
        /// <param name="cost">Стоимость товара.
        /// Должна быть от 0 до 100 000.</param>
        public Item(string name, string info, double cost)
        {
            _id = GetId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {
            _id = GetId();
            Info = "info";
            Name = "name";
            Cost = 0;
        }
    }
}
