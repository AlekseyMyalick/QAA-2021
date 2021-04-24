using System;

namespace HW_3
{
    public class Car : Vehicle
    {
        public string EngineType { get; set; }

        public Car (double engineVolume, string transmissionType, int maximumSpeed, string engineType)
            : base(engineVolume, transmissionType, maximumSpeed)
        {
            EngineType = engineType;
        }

        public override void GetFullinfo()
        {
            Console.WriteLine("\nType: " + typeof(Car).Name);
            base.GetFullinfo();
            Console.WriteLine("Engine type: " + EngineType);
        }
    }
}
