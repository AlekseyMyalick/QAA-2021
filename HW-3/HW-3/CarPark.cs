namespace HW_3
{
    public class CarPark
    {
        private Vehicle[] vehicles;

        public Vehicle this[int index]
        {
            get
            {
                return vehicles[index];
            }
            set
            {
                vehicles[index] = value;
            }
        }
    }
}
