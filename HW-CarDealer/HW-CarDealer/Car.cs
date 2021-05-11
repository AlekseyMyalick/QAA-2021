using System;

namespace HW_CarDealer
{
    public class Car
    {
        public Make Make { get; }

        public string Model { get; }

        public BodyType BodyType { get; }

        public EngineType EngineType { get; }

        public double EngineVolume { get; }

        public double Price { get; }

        public static int Count = 0;

        public Car (Make make, string model, BodyType bodyType, EngineType engineType, double engineVolume, double price)
        {
            ValidateModel(model);
            ValidateEngineVolume(engineVolume);
            ValidatePrice(price);

            Make = make;
            Model = model;
            BodyType = bodyType;
            EngineType = engineType;
            EngineVolume = engineVolume;
            Price = price;

            Count++;
        }

        public void ValidateModel(string model)
        {
            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void ValidateEngineVolume(double engineVolume)
        {
            if (engineVolume < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void ValidatePrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
