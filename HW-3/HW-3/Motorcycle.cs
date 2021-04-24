using System;

namespace HW_3
{
    public class Motorcycle : Vehicle
    {
        private const int maxNumberOfSeats = 5;
        private const int minNumberOfSeats = 1;

        private int _numberOfSeats;

        public int NumberOfSeats
        {
            get
            {
                return _numberOfSeats;
            }

            set
            {
                if (value < minNumberOfSeats || value > maxNumberOfSeats)
                {
                    throw new ArgumentOutOfRangeException(nameof(_numberOfSeats), $"The number of seats must be more than {minNumberOfSeats} and less than {maxNumberOfSeats}");
                }
                else
                {
                    _numberOfSeats = value;
                }
            }
        }

        public Motorcycle(double engineVolume, TransmissionTypeEnum transmissionType, int maximumSpeed, int numberOfSeats) 
            : base(engineVolume, transmissionType, maximumSpeed)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override void GetFullinfo()
        {
            base.GetFullinfo();
            Console.WriteLine("Number of seats: " + NumberOfSeats);
        }
    }
}
