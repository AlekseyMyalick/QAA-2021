using System;

namespace HW_3
{
    public class Car : Vehicle
    {
        public EngineTypeEnum EngineType { get; set; }

        public Car (double engineVolume, TransmissionTypeEnum transmissionType, int maximumSpeed, EngineTypeEnum engineType)
            : base(engineVolume, transmissionType, maximumSpeed)
        {
            EngineType = engineType;
        }

        public override void GetFullinfo()
        {
            base.GetFullinfo();
            Console.WriteLine("Engine type: " + EngineType);
        }
    }
}
