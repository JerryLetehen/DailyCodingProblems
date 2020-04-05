using System;
using System.Text;

namespace DailyCodingProblems
{
    /*
     * Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
     * For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].
     */

    public class Problem2 : IProblem
    {
        private readonly int[] array;
        private readonly int arrayLength;
        private int[] result;

        public Problem2(int[] array)
        {
            this.array = array;
            arrayLength = array.Length;
        }

        public void Solve()
        {
            result = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                result[i] = GetProductExceptIndex(i);
            }

            PrintResult();
        }

        private int GetProductExceptIndex(int index)
        {
            int result = 1;
            for (int i = 0; i < arrayLength; i++)
            {
                if (i != index)
                {
                    result *= array[i];
                }
            }

            return result;
        }

        private void PrintResult()
        {
            var builder = new StringBuilder();
            var resultLength = result.Length;
            builder.Append('[');
            for (int i = 0; i < resultLength; i++)
            {
                builder.Append(result[i]);
                if (i != resultLength - 1)
                {
                    builder.Append(',');
                }
            }

            builder.Append(']');
            Console.WriteLine(builder.ToString());
        }
    }
}