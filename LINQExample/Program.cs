using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LINQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICollection<Car> cars = new Collection<Car>
            {
                new Car
                {
                    Model = "BMW",
                    Colour = "Black"
                },

                new Car
                {
                    Model = "Mercedes",
                    Colour = "Black"
                },

                new Car
                {
                    Model = "Audi",
                    Colour = "White"
                },

                new Car
                {
                    Model = "Opel",
                    Colour = "Green"
                },

                new Car
                {
                    Model = "Golf",
                    Colour = "Blue"
                },
            };

            var blackcars = (from car
                             in cars
                             where car.Colour == "Black"
                             select car.Model).ToList();

            foreach (object car in blackcars)
            {
                Console.WriteLine("Black Cars: {0:0.00}" ,car);
            }

            Console.Read();
        }
    }
}
