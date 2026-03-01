namespace Demos.AbstractDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        Car Camero = new Car();
        Bike GT = new Bike();

        Boat SSO = new Boat();

        Vehicle vh = new Vehicle();
        
    }


     abstract class Vehicle
    {
        public int Speed = 0;
        public void go()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }

    class Car: Vehicle
    {
        int wheels = 4;
    }
    
    class Bike: Vehicle
    {
        int wheels = 2;
    }
    
    class Boat: Vehicle
    {
        int wheels = 0;
    }
}