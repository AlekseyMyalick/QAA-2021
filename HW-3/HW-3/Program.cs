using System;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Motorcycle motorcycle = new Motorcycle(-1.5d, TransmissionTypeEnum.Automatic, 120, 9);
                Car car = new Car(2.6d, TransmissionTypeEnum.Mechanical, 240, EngineTypeEnum.Electrical);
                Bus bus = new Bus(3.4d, TransmissionTypeEnum.Mechanical, 180, 4);
                Truck truck = new Truck(4.0d, TransmissionTypeEnum.Automatic, 200, 15.2d);

                CarPark carPark = new CarPark(new Vehicle[] { motorcycle, car, bus, truck });

                for (int i = 0; i < carPark.NumberOfCarsInTheCarPark; i++)
                {
                    carPark[i].GetFullinfo();
                }

            }
            catch (ArgumentOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
