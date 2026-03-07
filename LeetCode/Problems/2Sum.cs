/*

*/
using System;

namespace LeetCode.Problems
{
public class program
    {
        static void Main(string[] args)
        {
            //Sample Input
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            //Sample Output
            int[] result = TwoSum(nums, target);
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }

        //Brute Force Approach: O(n^2) time complexity.
        // we will have nested loops to check every pair of numbers in the array.
        public static int[] TwoSum(int[] nums, int target)
        {
            //Pointer 1: 
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentException("No two sum solution");
            // or return null; depending on how you want to handle the case where no solution is found
        }
    }
}
