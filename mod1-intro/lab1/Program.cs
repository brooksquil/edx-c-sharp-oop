using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called carl
            var Carl = new Car();

            // using dotnotation to call members on Carl
            Carl.Color = "White";
            Carl.Year = 2010;
            Carl.Mileage = 11000;

            // Output to the console window
            Console.WriteLine($"This car is painted {Carl.Color}, was built in {Carl.Year}, and has {Carl.Mileage} miles on it.");
        }
    }

    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, Mileage
        public class Car
        {
            // Defining properties
            public string Color { get; set; }
            public int Year { get; set; }
            public int Mileage { get; set; }
        }

}
