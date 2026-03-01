using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Console_App.DemoFiles
{
    internal class StringsDemo
    {
        public static void DisplayInfo()
        {
            Console.WriteLine("-- Strings Demo --");
            
            //strings
            // double quotes for strings
            string firstName = "John";
            // single character and single quotes, cant be empty
            char grade = 'A';
            //empty string
            string emptyString = "";

            //convert to String demo
            string textAge = "30";
            string textLong = "1234567890";
            string textDouble = "19.99";
            string textBool = "true";
            string textFloat = "19.99";
            string textDecimal = "19.99";

            //convert strings to other data types
            int age = Convert.ToInt32(textAge);
            long longNumber = Convert.ToInt64(textLong);
            double doubleNumber = Convert.ToDouble(textDouble);
            bool isTrue = Convert.ToBoolean(textBool);
            float floatNumber = Convert.ToSingle(textFloat);
            decimal decimalNumber = Convert.ToDecimal(textDecimal);

            //display converted values
            Console.WriteLine("Converted Values:"); 
            Console.WriteLine("Age (int): " + age);
            Console.WriteLine("Long Number (long): " + longNumber);
            Console.WriteLine("Double Number (double): " + doubleNumber);
            Console.WriteLine("Is True (bool): " + isTrue);
            Console.WriteLine("Float Number (float): " + floatNumber);
            Console.WriteLine("Decimal Number (decimal): " + decimalNumber);

        }




    }
}
