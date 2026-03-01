using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Console_App.DemoFiles
{

    public class ConstructorDemo
    {
        //display constructor demonstration
        public static void DisplayInfo()
        {
            //Creating an instance of ConstructorDemo to trigger the constructor
            //ConstructorDemo demoInstance = new ConstructorDemo();

            ////Using default constructor
            //Car car = Car.CreateSecretCar();
            //Console.WriteLine(Car.TotalCars);
            //Console.WriteLine($"Car Make: {car.Make}, Year: {car.Year}");

            //demo ConstructorDemo
            ConstructorDemo car1 = new ConstructorDemo();
        }

        //constructor demonstration
        public ConstructorDemo()
        {
            Console.WriteLine("ConstructorDemo: An instance of ConstructorDemo has been created.");
        }
    }

    public class Car
    {
        public string Make;
        public int Year;
        public static int TotalCars;

        // Static constructor
        static Car()
        {
            TotalCars = 0;
        }

        // Default constructor
        public Car()
        {
            Make = "Unknown";
            Year = 0;
            TotalCars++;
        }

        // Parameterized constructor
        public Car(string make, int year)
        {
            Make = make;
            Year = year;
            TotalCars++;
        }

        // Copy constructor
        public Car(Car other)
        {
            Make = other.Make;
            Year = other.Year;
            TotalCars++;
        }

        // Private constructor
        private Car(bool secret)
        {
            Make = "Secret Model";
            Year = 9999;
        }

        // Factory method for private constructor
        public static Car CreateSecretCar()
        {
            return new Car(true);
        }
    }

    //Default Constructor
    public class Bike
    {
        /*
        public string Brand;
        public int Speed;
        // Default constructor
        public Bike()
        {
            Brand = "Generic";
            Speed = 0;
        }
 
        */
        public string Brand;
        public int Speed;
        public int NumberOfWheels;
        //constuctor
        public Bike()
        {
            Brand = "Generic";
            Speed = 0;
            NumberOfWheels = 2; 
        }
        // Parameterized constructor
        public Bike(string brand, int speed, int numberOfWheels)
        {
            Brand = brand;
            Speed = speed;
            NumberOfWheels = numberOfWheels;
        }

    }

}
