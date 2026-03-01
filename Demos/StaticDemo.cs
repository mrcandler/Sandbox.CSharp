using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox_Console_App.DemoFiles
{
    internal class StaticDemo
    {
        //non-static method = you need to create an instance of the class to call this method
        public void ShowMessage()
        {
            Console.WriteLine("This is a demo class to illustrate the use of 'using' directives.");
        }

        //Static method = you can call this method without creating an instance of the class
        public static void ShowMessage(string str = "")
        {
            Console.WriteLine("This is a demo class to illustrate the use of 'using' directives.");
        }
    }
}
