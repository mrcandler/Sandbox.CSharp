using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Console_App.DemoFiles
{
    internal class ObjectDemo
    {
        //display person info   
        public static void DisplayInfo()
        {
            //use the Person class to create an object, using the new keyword to instantiate the object
            Person person = new Person()
            {
                FirstName = "Alice",
                Age = 30
            };
            
            //use console to print person info using string interpolation
            Console.WriteLine($"Person Name: {person.FirstName}, Age: {person.Age}");
        }
    }

    public class Person //object blueprint
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
    }

}
