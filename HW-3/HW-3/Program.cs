using System;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle(1.5d, "Automatic", 120, 3);
            Car car = new Car(2.6d, "Mechanical", 240, "Petrol");
            Bus bus = new Bus(3.4d, "Mechanical", 180, 4);
            Truck truck = new Truck(4.0d, "Automatic", 200, 15.2d);

            CarPark carPark = new CarPark(new Vehicle[] { motorcycle, car, bus, truck });

            for (int i = 0; i < carPark.NumberOfCarsInTheCarPark; i++)
            {
                carPark[i].GetFullinfo();
            }

        }
    }
}
