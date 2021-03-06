namespace DailyCodingProblems
{
    /*
     * Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
     * For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
     */

    public class WhetherTwoNumbersAddUpTo : IProblem
    {
        private readonly int[] numbers;
        private readonly int addUpNumber;

        private int firstNumber;
        private int secondNumber;

        public WhetherTwoNumbersAddUpTo(int[] numbers, int addUpNumber)
        {
            this.numbers = numbers;
            this.addUpNumber = addUpNumber;
        }

        public void Solve()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                firstNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    secondNumber = numbers[j];
                    if (AreAddUpTo())
                    {
                        PrintPositiveResult();
                        return;
                    }
                }
            }

            PrintNegativeResult();
        }

        private void PrintPositiveResult()
        {
            System.Console.WriteLine($"{firstNumber} + {secondNumber} = {addUpNumber}");
        }

        private void PrintNegativeResult()
        {
            System.Console.WriteLine($"No any given numbers are add up to {addUpNumber}");
        }

        private bool AreAddUpTo()
        {
            return firstNumber + secondNumber == addUpNumber;
        }
    }
}