using FlightsList.Model.Enums;
using System;
namespace FlightsList.Model
{
    /// <summary>
    /// Хранит информацию о полёте.
    /// </summary>
    public class FlightInfo
    {
        /// <summary>
        /// Место отправления.
        /// </summary>
        private string _departurePoint;

        /// <summary>
        /// Время в полёте.
        /// </summary>
        private double _flightTime;

        /// <summary>
        /// Место назначения.
        /// </summary>
        private string _destination;

        /// <summary>
        /// Время вылета.
        /// </summary>
        private DateTime _departureDate = DateTime.Now;

        /// <summary>
        /// Тип вылета.
        /// </summary>
        private FlightType _type;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FlightInfo"/>
        /// </summary>
        public FlightInfo()
        {
            DeparturePoint = "";
            Destination = "";
        }

        /// <summary>
        /// Метод для вывода в список FlightsListBox строки с информацией о рейсе.
        /// </summary>
        /// <returns>Возвращает строку, содержащую информацию
        /// о дате вылета, месте отправления и месте назначения.</returns>
        public string FlightDescription()
        {
            return $"{DepartureDate} : {DeparturePoint} - {Destination}";
        }

        /// <summary>
        /// Возвращает и задаёт значение места отправления.
        /// </summary>
        public string DeparturePoint
        {
            get
            {
                return _departurePoint;
            }
            set
            {
                Validator.AssertValueInRange(nameof(DeparturePoint), value.Length, 0, 100);
                _departurePoint = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение времени в полёте.
        /// </summary>
        public double FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                Validator.AssertValueInRange(nameof(FlightTime), value, 0, 1000);
                _flightTime = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт место назначения.
        /// </summary>
        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Destination), value.Length, 0, 100);
                _destination = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт дату вылета.
        /// </summary>
        public DateTime DepartureDate
        {
            get
            {
                return _departureDate;
            }
            set
            {
                _departureDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт тип вылета.
        /// </summary>
        public FlightType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
    }
}
