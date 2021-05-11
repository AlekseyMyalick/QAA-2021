using System;
using System.Collections.Generic;

namespace HW_CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>() { new Car(Make.MercedesBenz, "C-class", BodyType.Sedan, EngineType.Gasoline, 1800, 5000),
                                                  new Car(Make.Renault, "Logan", BodyType.Hatchback, EngineType.Diesel, 2000, 3800),
                                                  new Car(Make.Volvo, "Volvo", BodyType.Coupe, EngineType.Gasoline, 1500, 15000)};

            CarDealer carDealer = new CarDealer(carList);

            Func<Car, double> averagePrice = x => x.Price;
            Func<Car, double> averageEngineVolume = x => x.EngineVolume;

            Predicate<Car> countGasoline = x => x.EngineType == EngineType.Gasoline;
            Predicate<Car> countLessThen = x => x.Price < 10000;

            Console.WriteLine(carDealer.GetAverage(averageEngineVolume));
            Console.WriteLine(carDealer.GetCount(countLessThen));
            Console.WriteLine(carDealer.GetMaxValue(averagePrice));
        }
    }
}
