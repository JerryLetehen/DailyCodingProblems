namespace DailyCodingProblems
{
    /*
     * Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
     * For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
     */

    public class Problem1 : Problem
    {
        private readonly int[] numbers;
        private readonly int addUpNumber;

        public Problem1(int[] numbers, int addUpNumber)
        {
            this.numbers = numbers;
            this.addUpNumber = addUpNumber;
        }

        public override void Solve()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];
                int secondNumber;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    secondNumber = numbers[j];
                    if (IsAddUpTo(ref firstNumber, ref secondNumber))
                    {
                        PrintPositiveResult(ref firstNumber, ref secondNumber);
                        return;
                    }
                }
            }

            PrintNegativeResult();
        }

        private void PrintPositiveResult(ref int firstNumber, ref int secondNumber)
        {
            System.Console.WriteLine($"{firstNumber} + {secondNumber} = {addUpNumber}");
        }

        private void PrintNegativeResult()
        {
            System.Console.WriteLine($"No any given numbers are add up to {addUpNumber}");
        }

        private bool IsAddUpTo(ref int firstNumber, ref int secondNumber)
        {
            return firstNumber + secondNumber == addUpNumber;
        }
    }
}