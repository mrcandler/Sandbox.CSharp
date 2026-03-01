using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Console_App.DemoFiles
{
    internal class NumbersDemo
    {
        public static void DisplayInfo()
        {
            Console.WriteLine("-- Variables Demo --");

            //variables

            //get the min value of int
            Console.WriteLine(@"Int Max value = {0}", int.MaxValue);
            Console.WriteLine(@"Int Min value = {0}", int.MinValue);

            //get the max value of long, use L suffix for long literals, int 64 bit
            long bigNumber = 9000000000L;
            Console.WriteLine(@"Long Max value = {0}", long.MaxValue);
            Console.WriteLine(@"Long Min value = {0}", long.MinValue);

            //d suffix for double literals
            double doubleNumber = 19.99d;
            Console.WriteLine(@"double Max value = {0}", double.MaxValue);
            Console.WriteLine(@"double Min value = {0}", double.MinValue);

            //f suffix for float literals, float 32 bit
            float floatNumber = 19.99f;
            Console.WriteLine(@"float Max value = {0}", float.MaxValue);
            Console.WriteLine(@"float Min value = {0}", float.MinValue);

            //decimal 128 bit, m suffix for decimal literals    
            decimal decimalNumber = 19.99m;
            Console.WriteLine(@"decimal Max value = {0}", decimal.MaxValue);
            Console.WriteLine(@"decimal Min value = {0}", decimal.MinValue);

            //Increment and Decrement Operators
            int counter = 0;
            counter++;  // Increment
            counter--;  // Decrement
            Console.WriteLine("Counter after Increment and Decrement: " + counter);

            //modulus operator  
            int dividend = 10;
            int divisor = 3;
            int remainder = dividend % divisor;
            Console.WriteLine("Remainder of " + dividend + " divided by " + divisor + " is: " + remainder);
        }
    }
}
