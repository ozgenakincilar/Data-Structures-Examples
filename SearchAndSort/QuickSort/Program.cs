namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Original Array:");
            PrintArray(arrayToSort);

            QuickSort(arrayToSort, 0, arrayToSort.Length - 1);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arrayToSort);
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        public static void QuickSort(int[] array,int low,int high)
        {
            if(low< high)
            {
                int partitionIndex= Partition(array,low, high);
                QuickSort(array, low, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, high);
            }
        }

        public static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
