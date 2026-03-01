using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Console_App.DemoFiles
{
    public class ClassDemo
    {
        //properties
        public string fName { get; set; }
        public string lName { get; set; }

        internal static void DisplayInfo()
        {
            // Create an instance of Class B
            B bInstance = new B();
            bInstance.ShowMessage();
        }

        //methods :: Members
        public void ShowFullName()
        {
            Console.WriteLine($"Full Name: {fName} {lName}");
        }
    }

    // create a simple class A where Be Inherit class Demo
    public class A
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("This text can not be used");
        }

    }

    // create a simple class B where Be Inherit class Demo
    public class B : A
    {
        // Override ShowMessage method
        public override void ShowMessage()
        {
            Console.WriteLine("This is class B inheriting from class A");
        }

    }
}