namespace FibonacciNumbers
{
    internal class Program
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main()
        {
            Console.Write("Enter the number of Fibonacci numbers to generate: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFibonacci Series:");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
        }
    }
}

