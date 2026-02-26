namespace DataStructures
{
    using System;
    using System.Runtime.InteropServices;

    class TheSandbox
    {
        static void Main(string[] args)
        {
            var input = new int[] { -1,0,1, 2,-1,-4,2,-2};
            RunCode(input);
        }

        static void RunCode(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i+1;j< input.Length; j++)
                {
                    for (int k = j+1; k < input.Length; k++)
                    {
                        for (int l = k+1; l < input.Length; l++)
                        {
                            if(input[i] + input[j] + input[k] + input[l] == 0)
                            {
                                Console.WriteLine($"Quadruplet found: {input[i]}, {input[j]}, {input[k]}, {input[l]}");
                            }
                        }

                    }
                }
            }
        }
    }
}