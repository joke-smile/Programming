using System;

namespace ListOfFlights.Model
{
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

        public double FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                Validator.AssertValueInRange(nameof(FlightTime), value, 1, 1000);
                _flightTime = value;
            }
        }
        public string DeparturePoint
        {
            get
            {
                return _departurePoint;
            }
            set
            {
                Validator.AssertValueInRange(nameof(DeparturePoint), value.Length, 1, 100);
                _departurePoint = value;
            }
        }
        /// <summary>
        /// Место назначения.
        /// </summary>
        private string _destination;

        /// <summary>
        /// Время вылета.
        /// </summary>
        private DateTime _departureTime;

        public DateTime DepartureTime
        {
            get
            {
                return _departureTime;
            }
            set
            {
                _departureTime = value;
            }
        }
        /// <summary>
        /// Тип вылета.
        /// </summary>
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                
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
                Validator.AssertValueInRange(nameof(Destination), value.Length, 1, 100);
                Destination = value;
            }
        }
        public FlightInfo(string departurePoint, string destination, double flightTime, string type)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
            Type = type;
        }
    }
}
