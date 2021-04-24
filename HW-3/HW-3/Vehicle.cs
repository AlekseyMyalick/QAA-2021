using System;

namespace HW_3
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Engine volume, which is measured in liters.
        /// </summary>
        public double EngineVolume { get; set; }

        public string TransmissionType { get; set; }

        /// <summary>
        /// Maximum speed, which is measured in kilometers per hour.
        /// </summary>
        public int MaximumSpeed { get; set; }

        public Vehicle (double engineVolume, string transmissionType, int maximumSpeed)
        {
            EngineVolume = engineVolume;
            TransmissionType = transmissionType;
            MaximumSpeed = maximumSpeed;
        }

        public virtual void GetFullinfo()
        {
            Console.WriteLine("Engine volume: " + EngineVolume + "l" +
                              "Transmission type: " + TransmissionType +
                              "Maximum speed: " + MaximumSpeed + "km/h");
        }
    }
}
