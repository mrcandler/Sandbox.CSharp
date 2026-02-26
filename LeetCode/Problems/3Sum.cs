namespace DataStructures
{
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;

    class TheSandbox
    {
        static void Main(string[] args)
        {
            var input = new int[] { -1,0,1, 2,-1,-4,2,-2};
            RunCode2(input);
        }

        static void RunCode(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i+1;j< input.Length; j++)
                {
                    for (int k = j+1; k < input.Length; k++)
                    {
                        if(input[i] + input[j] + input[k] == 0)
                        {
                            Console.WriteLine($"Triplet found: {input[i]}, {input[j]}, {input[k]}");
                        }
                    }
                }
            }
        }

         static void RunCode2(int[] input)
        {
            //method printout
            Console.WriteLine("-- RunCode 2 --");
            var output = new List<List<int>>();

            Array.Sort(input);

            for (int i = 0; i < input.Length - 2; i++)
            {      

                int low = i + 1;
                int high = input.Length - 1;            
            }
            
            int sum = NumberStyles[i] + NumberStyles[low]+NumberStyles[high];

            while(low < high)
            {                
                if(sum == 0)
                {
                    output.Add(new List<int>(){input[i],input[low],input[high]});
                }
            }

            Console.WriteLine(output);
        }








    }
}