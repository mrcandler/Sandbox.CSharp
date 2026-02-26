namespace DataStructures
{
    using System;

    class ArrayDemo
    {
        static void Main(string[] args)
        {
            //List all type in Array and initializations?
            int[] intx = {}; //Implicitly initializations - Shorthand (most common)
            string[] strx = new string[]{}; //Explicitly initializations
            bool[] box = new bool[]{};
            double[] dbbx = new double[]{};
            byte[] bytesx = new byte[] {};
            short[] shortsx = new short[] {};
            long[] longsx = new long[] {};
            float[] floatsx = new float[] {};
            decimal[] decimalsx = new decimal[] {};

            //List all type in Array and initializations and assign values?
            int[] intxv = {1,2,3}; //Implicitly initializations - Shorthand (most common)
            string[] strxv = new string[]{"A","B","C"}; //Explicit                  
            bool[] boxv = new bool[]{true,false,true};
            double[] dbbxv = new double[]{1.1,2.2,3.3};
            byte[] bytesxv = new byte[] {1,2,3};
            short[] shortsxv = new short[] {10,20,30};
            long[] longsxv = new long[] {100L,200L,300L};
            float[] floatsxv = new float[] {1.1f,2.2f,3.3f};
            decimal[] decimalsxv = new decimal[] {1.1m,2.2m,3.3m};  

            // Declare an empty array 
            int[] emptyArray = new int[0];

            // Declare an array of integers with size 5 only
            int[] numbersWithSize = new int[5];

            //How to modify an element in the array?
            numbersWithSize[2] = 99;
            Console.WriteLine("After modification, element at index 2: " + numbersWithSize[2]);

            // how to get the length of an array?
            Console.WriteLine("Length of intxv array: " + intxv.Length);

            // How to access and print each element in the array
            for (int i = 0; i < numbersWithSize.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + numbersWithSize[i]);
            }

            //handle empty array case
            if (emptyArray.Length == 0)
            {
                Console.WriteLine("The emptyArray has no elements.");   
            }

        }
    }
}

/*
Test Questons:
1. How do you declare an array without initializing it in C#?
2. How do you declare an array with a specific size only in C#?
3. How do you declare an empty array in C#?
4. How do you declare and initialize an array with values in C#?
5. How do you modify an element in an array in C#?
6. How do you get the length of an array in C#?

Answers:
1. You can declare an array without initializing it by specifying the type and using empty curly braces, e.g., int[] arr = {};
2. You can declare an array with a specific size only by using the new keyword followed by the type and size, e.g., int[] arr = new int[5];
3. You can declare an empty array by specifying the type and using the new keyword with size 0, e.g., int[] emptyArray = new int[0];
4. You can declare and initialize an array with values using curly braces, e.g., int[] arr = {1, 2, 3};
5. You can modify an element in an array by accessing it via its index and assigning a new value, e.g., arr[2] = 99;
6. You can get the length of an array using the Length property, e.g., int length = arr.Length;         

Excersise:
1. Declare an array of strings with a size of 4 and initialize it with the names of four fruits.
2. Modify the second element of the array to a different fruit name.
3. Print the length of the array.
4. Iterate through the array and print each fruit name.
5. Declare an empty array of doubles and check if its length is zero, printing a message if it is.
6. Declare an array of booleans with size 3, initialize it with values, and then modify the last element to false. Print all elements of the array.


More Questions for practice:
-- How do you handle empty arrays?
Check if the length is equal to 0 with if condition, if true return text info

-- What are some of the properties and methods for arrays? 


-- What happens when you try to access an element that does not exist? 
Error, you will get an error of indexOutOfRangeException - index was outside the bounds of the array. 

-- Arrays have a fixed size, the size is set in the [size] and is fixed after created. 

-- Index start at 0


-- how to update an array?
ArryName[IndexHere] = New Value Here;


-- how to display a single item, or each item? 
- w/ ArrayName[index]
- For or Foreach

*/
