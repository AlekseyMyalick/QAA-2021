using System;

namespace HW_3
{
    public class Bus : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Bus(double engineVolume, string transmissionType, int maximumSpeed, int numberOfDoors)
            : base(engineVolume, transmissionType, maximumSpeed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void GetFullinfo()
        {
            Console.WriteLine("\nType: " + typeof(Bus).Name);
            base.GetFullinfo();
            Console.WriteLine("Number of doors: " + NumberOfDoors);
        }
    }
}
