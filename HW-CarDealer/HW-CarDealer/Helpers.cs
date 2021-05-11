using System;

namespace HW_CarDealer
{
    public static class Helpers
    {
        public static double GetMaxValue(this CarDealer carDealer, Func<Car, double> maxFunc)
        {
            double maxValue = maxFunc(carDealer.CarList[0]);

            for (int i = 1; i < carDealer.CarList.Count; i++)
            {
                if (maxFunc(carDealer.CarList[i]) > maxValue)
                {
                    maxValue = maxFunc(carDealer.CarList[i]);
                }
            }

            return maxValue;
        }
    }
}
