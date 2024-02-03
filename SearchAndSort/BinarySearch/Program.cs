namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            int targetElement = 66;

            Console.WriteLine("Sorted Array:");
            foreach (var element in sortedArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            int result = BinarySearch(sortedArray, targetElement);

            if (result != -1)
            {
                Console.WriteLine($"{targetElement} found at index {result}");
            }
            else
            {
                Console.WriteLine($"{targetElement} not found in the array");
            }

        }


        public static int BinarySearch(int[] array, int target)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1; // target element couldnt find
        }
    }
}
