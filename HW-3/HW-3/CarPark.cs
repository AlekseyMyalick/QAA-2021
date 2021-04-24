namespace HW_3
{
    public class CarPark
    {
        private Vehicle[] _vehicles;

        public CarPark (Vehicle[] vehicles)
        {
            _vehicles = vehicles;
            NumberOfCarsInTheCarPark = _vehicles.Length;
        }

        public int NumberOfCarsInTheCarPark { get; }

        public Vehicle this[int index]
        {
            get
            {
                return _vehicles[index];
            }
            set
            {
                _vehicles[index] = value;
            }
        }
    }
}
