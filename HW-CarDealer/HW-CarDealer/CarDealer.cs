using System;
using System.Collections.Generic;

namespace HW_CarDealer
{
    public class CarDealer
    {
        public List<Car> CarList { get; set; }

        public CarDealer(List<Car> carList)
        {
            CarList = carList;
        }

        public double GetAverage(Func<Car, double> averageFunc)
        {
            double totalValue = 0;

            foreach (Car car in CarList)
            {
                totalValue += averageFunc(car);
            }

            return totalValue / Car.Count;
        }

        public int GetCount(Predicate<Car> countFunc)
        {
            int count = 0;

            foreach (Car car in CarList)
            {
                if (countFunc(car))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
