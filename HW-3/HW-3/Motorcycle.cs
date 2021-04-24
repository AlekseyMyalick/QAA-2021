using System;

namespace HW_3
{
    public class Motorcycle : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Motorcycle(double engineVolume, string transmissionType, int maximumSpeed, int numberOfSeats) 
            : base(engineVolume, transmissionType, maximumSpeed)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override void GetFullinfo()
        {
            base.GetFullinfo();
            Console.WriteLine("\nNumber of seats: " + NumberOfSeats);
        }
    }
}
