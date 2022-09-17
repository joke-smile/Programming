using System;

namespace ListOfFlights.Model
{
    public class proba
    {
        private int _something;
        public int Something
        {
            get => _something;
            set
            {
                Validator.AssertValueInRange(nameof(Something), value, 0, 1000);
                _something = value;
            }
        }
    }
}
