using System;

namespace ListOfFlights.Model
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
        private DateTime _departureData = DateTime.Now;

        /// <summary>
        /// Тип вылета.
        /// </summary>
        private FlightType _type;

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
                //Validator.AssertValueInRange(nameof(FlightTime), value, 1, 1000);
                _flightTime = value;
            }
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
                //Validator.AssertValueInRange(nameof(DeparturePoint), value.Length, 1, 100);
                _departurePoint = value;
            }
        }

        public DateTime DepartureData
        {
            get
            {
                return _departureData;
            }
            set
            {
                //Validator.AssertData(value);
                _departureData = value;
            }
        }

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
        public string Destination
        {
            get 
            { 
                return _destination;
            }
            set
            {
                //Validator.AssertValueInRange(nameof(Destination), value.Length, 1, 100);
                _destination = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="FlightInfo"/>
        /// </summary>
        /// <param name="departurePoint">Место отправления. <br/>
        /// Должно иметь не больше 100 символов.</param>
        /// <param name="destination">Место назначения. <br/>
        /// Должно иметь не больше 100 символов.</param>
        /// <param name="flightTime">Время полёта. <br/>
        /// Должно быть не больше 1000 минут</param>
        /// <param name="type">Тип перелёта. </param>
        /// <param name="departureData">Дата вылета. <br/>
        /// Должна быть не раньше сегодняшнего дня</param>
        public FlightInfo(string departurePoint, string destination, double flightTime, FlightType type, DateTime departureData)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
            Type = type;
            DepartureData = departureData;

        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="FlightInfo"/>
        /// </summary>
        public FlightInfo()
        {
            
        }
        public string FlightDescription()
        {
            return $"{DepartureData} : {DeparturePoint} - {Destination}";
        }
    }
}
