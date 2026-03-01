using System;
using System.IO;
//The using directive creates an alias for a namespace or imports types defined in other namespaces

namespace Sandbox_Console_App.DemoFiles
{
    public class UsingDemo
    {
        public const string createFile = @"C:\Tmp\Delete_When_Done.txt";
        public const string textToWrite = "Hello, this is a test message!ee";

        public static void DisposeDemo()
        {
            // Use the using statement to ensure the StreamWriter is properly disposed of
            using (StreamWriter sw = new StreamWriter(createFile))
            {
                try
                {
                    sw.WriteLine(textToWrite);
                }
                catch (System.Exception)
                {
                    throw;
                }
                
            }

            // Use the using statement to ensure the StreamWriter is properly disposed of
            using (StreamReader sr = new StreamReader(createFile))
            {
                try
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine("File Content: " + content);
                }
                catch (System.Exception)
                {
                    throw;
                }

            }
        }
    }
}
