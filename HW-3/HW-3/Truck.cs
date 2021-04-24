using System;

namespace HW_3
{
    public class Truck : Vehicle
    {
        /// <summary>
        /// Carrying capacity, which is measured in tons.
        /// </summary>
        public double CarryingCapacity { get; set; }

        public Truck(double engineVolume, string transmissionType, int maximumSpeed, double carryingCapacity)
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
