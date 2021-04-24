using System;

namespace HW_3
{
    public class Truck : Vehicle
    {
        private const double minCarryingCapacity = 0d;
        private const double maxCarryingCapacity = 100d;

        private double _carryingCapacity;

        /// <summary>
        /// Carrying capacity, which is measured in tons.
        /// </summary>
        public double CarryingCapacity
        {
            get
            {
                return _carryingCapacity;
            }

            set
            {
                if (value < minCarryingCapacity || value > maxCarryingCapacity)
                {
                    throw new ArgumentOutOfRangeException(nameof(_carryingCapacity), $"The carrying capacity must be more than {minCarryingCapacity} and less than {maxCarryingCapacity}");
                }
                else
                {
                    _carryingCapacity = value;
                }
            }
        }

        public Truck (double engineVolume, TransmissionTypeEnum transmissionType, int maximumSpeed, double carryingCapacity)
            : base(engineVolume, transmissionType, maximumSpeed)
        {
            CarryingCapacity = carryingCapacity;
        }

        public override void GetFullinfo()
        {
            base.GetFullinfo();
            Console.WriteLine("Carrying capacity: " + CarryingCapacity);
        }
    }
}
