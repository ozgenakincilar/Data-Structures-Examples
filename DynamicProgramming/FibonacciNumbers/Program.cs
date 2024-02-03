namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please write the input ");
            var input = Console.ReadLine();
            var result = Fibonacci(Convert.ToInt32(input));
            Console.WriteLine($" result is : {result}");
        }

        public static int Fibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}

