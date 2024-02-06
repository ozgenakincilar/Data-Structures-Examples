namespace EvaluateReversePolishNotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens1 = { "2", "1", "+", "3", "*" };
            Console.WriteLine($"Result 1: {EvaluateRPN(tokens1)}");

            string[] tokens2 = { "4", "13", "5", "/", "+" };
            Console.WriteLine($"Result 2: {EvaluateRPN(tokens2)}");

            string[] tokens3 = { "10", "6", "9", "3", "/", "-", "*" };
            Console.WriteLine($"Result 3: {EvaluateRPN(tokens3)}");
        }



        public static int EvaluateRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int operand))
                {
                    // If the token is an operand, push it onto the stack
                    stack.Push(operand);
                }
                else
                {
                    // If the token is an operator, pop operands, perform the operation, and push the result back
                    int operand2 = stack.Pop();
                    int operand1 = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(operand1 + operand2);
                            break;
                        case "-":
                            stack.Push(operand1 - operand2);
                            break;
                        case "*":
                            stack.Push(operand1 * operand2);
                            break;
                        case "/":
                            stack.Push(operand1 / operand2);
                            break;
                        default:
                            throw new ArgumentException("Invalid operator");
                    }
                }
            }

            // The final result should be on the top of the stack
            return stack.Pop();
        }
    }
}