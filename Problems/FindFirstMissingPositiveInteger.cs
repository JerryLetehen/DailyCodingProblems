using System;

namespace DailyCodingProblems
{
    /*
     * Given an array of integers, find the first missing positive integer in linear time and constant space.
     * In other words, find the lowest positive integer that does not exist in the array. The array can contain duplicates and negative numbers as well.
     * For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
     * You can modify the input array in-place.
     */

    public class FindFirstMissingPositiveInteger : IProblem
    {
        private int[] array;

        public FindFirstMissingPositiveInteger(int[] array)
        {
            this.array = array;
        }

        public void Solve()
        {
            int result = GetFirstMissingPositive(array);
            PrintResult(result);
        }

        private int GetFirstMissingPositive(int[] nums)
        {
            Array.Sort(nums);
            int result = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
                if (number <= 0)
                {
                    continue;
                }

                if (number > result)
                {
                    return result;
                }

                if (number < result)
                {
                    continue;
                }

                result++;
            }

            return result;
        }

        private void PrintResult(int result)
        {
            Console.WriteLine("Result : " + result);
        }
    }
}