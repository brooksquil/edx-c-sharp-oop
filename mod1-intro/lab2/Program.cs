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

            var Car2 = new Car("Red", 2008);

            // Access static members
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
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

            // Creates integer variable called "instance" and assigns value to 0
            private static int instances = 0;
            // Adding a Constructor
            // This constructor instantiates a Car() object while only having the cars color and year
            public Car(string color, int year)
            {
                this.Color = color;
                this.Year = year;
                // Every time the constructor runs, increment "instances" 
                instances++;
            }

            // Adding another Constructor
            // This Constructor instantiates a Car() object while only having the car's year and mileage information available
            public Car(int year, int mileage)
            {
                this.Year = year;
                this.Mileage = mileage;
                // Every time the constructor runs, increment "instances"
                instances++;
            }


            public Car()
            {
                // Every time the constructor runs, increment "instances"
                instances++;
            }

            //Declare static member
            public static int CountCars()
            {
                return instances;
            }
        }

}