using System;

namespace HW_3
{
    public class Bus : Vehicle
    {
        public const int minNumberOfDoors = 1;
        public const int maxNumberOfDoors = 6;

        private int _numberOfDoors;

        public int NumberOfDoors
        {
            get
            {
                return _numberOfDoors;
            }

            set
            {
                if (value < minNumberOfDoors || value > maxNumberOfDoors)
                {
                    throw new ArgumentOutOfRangeException(nameof(_numberOfDoors), $"The number of doors must be more than {minNumberOfDoors} and less than {maxNumberOfDoors}");
                }
                else
                {
                    _numberOfDoors = value;
                }
            }
        }

        public Bus(double engineVolume, TransmissionTypeEnum transmissionType, int maximumSpeed, int numberOfDoors)
            : base(engineVolume, transmissionType, maximumSpeed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void GetFullinfo()
        {
            base.GetFullinfo();
            Console.WriteLine("Number of doors: " + NumberOfDoors);
        }
    }
}
