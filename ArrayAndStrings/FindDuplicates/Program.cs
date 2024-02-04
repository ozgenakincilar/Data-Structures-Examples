namespace FindDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 2, 7, 8, 2, 1, 4 };

            Console.WriteLine("Original Array:");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            List<int> duplicateList = FindDuplicates(array);

            if (duplicateList.Count > 0)
            {
                Console.WriteLine("\nDuplicate Elements:");
                foreach (var duplicate in duplicateList)
                {
                    Console.Write(duplicate + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nNo duplicates found in the array.");
            }
        }

        public static List<int> FindDuplicates(int[] nums)
        {
            List<int> duplicates = new List<int>();
            HashSet<int> set = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!set.Add(num))
                {
                    duplicates.Add(num);
                }
            }

            return duplicates;
        }
    }
}
