using System.Globalization;

namespace LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
            var result=LenghtOfLIS(numbers);
            Console.WriteLine($"Longest subsequence is: {result}");
            Console.ReadLine();
        }

        public static int LenghtOfLIS(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int[] dp = new int[numbers.Length];
            dp[0] = 1;

            int maxLenght = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] > numbers[j] && dp[i] < dp[j] + 1)
                    {
                        dp[i] = dp[j] + 1;
                    }
                }
                maxLenght = Math.Max(maxLenght, dp[i]);
            }

            return maxLenght;
        }
    }
}
