namespace TrappingRainWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heights = { 0, 1, 0, 2, 1, 0, 3, 1, 0, 1, 2 };
            Console.WriteLine($"trapped rain water area is : {GetTrappedRainWaterOptimal(heights)}");
        }

        static int GetTrappedRainWaterBruteForce(int[] heights)
        {
            int totalWater = 0;

            for (int p = 0; p < heights.Length; p++) // p stands for pointer
            {
                int leftp = p;
                int rightp = p;
                int maxLeft = 0;
                int maxRight = 0;

                while (leftp >= 0)
                {
                    maxLeft = Math.Max(maxLeft, heights[leftp]);
                    leftp--;
                }
                while (rightp < heights.Length)
                {
                    maxRight = Math.Max(maxRight, heights[rightp]);
                    rightp++;
                }

                int currentWater = Math.Min(maxLeft, maxRight) - heights[p];

                if (currentWater >= 0) // check the walls
                {
                    totalWater += currentWater;
                }
            }
            return totalWater;
        }

        static int GetTrappedRainWaterOptimal(int[] heights)
        {
            // two pointer technique
            int leftp=0;
            int rightp=heights.Length-1;
            int rightMax = 0;
            int leftMax = 0;
            int total = 0;

            while(leftp<rightp)
            {
                if (heights[leftp] <= heights[rightp])
                {
                    if (heights[leftp] >= leftMax)
                    {
                        leftMax = heights[leftp];
                    }
                    else
                    {
                        total += leftMax - heights[leftp];
                    }

                    leftp++;
                }
                else
                {
                    if (heights[rightp]>=rightMax)
                    {
                        rightMax = heights[rightp];
                    }
                    else
                    {
                        total += rightMax - heights[rightp];
                    }
                    rightp--;
                }
            }

                return total;
                // time comp: O(n)
                // space comp: O(1)
        }
    }
}
