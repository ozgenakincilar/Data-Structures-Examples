namespace QueueImplementingUsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            QueueUsingStacks queue = new QueueUsingStacks();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            Console.WriteLine($"Peek: {queue.Peek()}");
            Console.WriteLine($"Is Empty: {queue.IsEmpty()}");
        }
    }

    public class QueueUsingStacks
    {
        private Stack<int> stack1;
        private Stack<int> stack2;

        public QueueUsingStacks()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void Enqueue(int item)
        {
            stack1.Push(item);
        }

        public int Dequeue()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1; // or throw an exception
            }

            if (stack2.Count == 0)
            {
                // Transfer elements from stack1 to stack2
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();
        }

        public int Peek()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1; // or throw an exception
            }

            if (stack2.Count == 0)
            {
                // Transfer elements from stack1 to stack2
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Peek();
        }

        public bool IsEmpty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
        }
    }

}
