using System;

namespace HW_3
{
    public abstract class Vehicle
    {
        private const double maxEngineVolume = 10d;
        private const double minEngineVolume = 0d;
        private const int maxMaximumSpeed = 480;
        private const int minMaximumSpeed = 0;

        private double _engineVolume;
        private int _maximumSpeed;

        /// <summary>
        /// Engine volume, which is measured in liters.
        /// </summary>
        public double EngineVolume 
        {
            get
            {
                return _engineVolume;
            }

            set
            {
                if (value < minEngineVolume || value > maxEngineVolume)
                {
                    throw new ArgumentOutOfRangeException(nameof(_engineVolume), $"Engine volume must be greater than {minEngineVolume} and less than {maxEngineVolume}.");
                }
                else
                {
                    _engineVolume = value;
                }
            } 
        }

        public TransmissionTypeEnum TransmissionType { get; set; }

        /// <summary>
        /// Maximum speed, which is measured in kilometers per hour.
        /// </summary>
        public int MaximumSpeed
        {
            get
            {
                return _maximumSpeed;
            }

            set
            {
                if (value < minMaximumSpeed || value > maxMaximumSpeed)
                {
                    throw new ArgumentOutOfRangeException(nameof(_engineVolume), $"The maximum speed must be greater than {minMaximumSpeed} and less than {maxMaximumSpeed} km/h");
                }
                else
                {
                    _maximumSpeed = value;
                }
            }
        }

        public Vehicle (double engineVolume, TransmissionTypeEnum transmissionType, int maximumSpeed)
        {
            EngineVolume = engineVolume;
            TransmissionType = transmissionType;
            MaximumSpeed = maximumSpeed;
        }

        public virtual void GetFullinfo()
        {
            Console.WriteLine("\nType: " + this.GetType().Name +
                              "\nEngine volume: " + EngineVolume + "l" +
                              "\nTransmission type: " + TransmissionType +
                              "\nMaximum speed: " + MaximumSpeed + "km/h");
        }
    }
}
