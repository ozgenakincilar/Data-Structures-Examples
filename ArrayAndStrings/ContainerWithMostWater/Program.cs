namespace ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] area = { 7, 1, 2, 3, 9 }; // area= min(a,b) * (bi-ai)
            var result = GetMaxWaterContainer(area);
            Console.WriteLine($"Max area is {result}");
        }

        public static int GetMaxWaterContainerBruteForce(int[] heights)
        {
            int maxArea = 0;
            for (int p1 = 0; p1 < heights.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < heights.Length; p2++)
                {
                    var height = Math.Min(heights[p1], heights[p2]);
                    var width = p2 - p1;
                    var area = height * width;
                    maxArea = Math.Max(maxArea, area);

                }
            }
            return maxArea;
            // time  : O(n^2)
            // space : O(1)
        }
        public static int GetMaxWaterContainer(int[] heights)
        {
            var maxArea = 0;
            int p1 = 0;
            int p2 = heights.Length - 1;

            while (p1 <= p2)
            {
                var height = Math.Min(heights[p1], heights[p2]);
                var width = p2 - p1;
                var area = height * width;
                maxArea = Math.Max(maxArea, area);

                if (heights[p1] <= heights[p2])
                {
                    p1++;
                }
                else
                {
                    p2--;
                }
            }

            return maxArea;
        }

    }
}
