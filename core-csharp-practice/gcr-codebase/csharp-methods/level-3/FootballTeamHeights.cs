using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods.level_3
{
    public class FootballTeamHeights
    {
        // b. Generate random heights between 150 and 250 cm
        public static int[] GenerateHeights()
        {
            int[] heights = new int[11];
            Random random = new Random();

            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(150, 251); // 150 to 250 cm
            }

            return heights;
        }

        // c. find sum of heights
        public static int FindSum(int[] heights)
        {
            int sum = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }
            return sum;
        }

        // d.find mean height
        public static double FindMean(int[] heights)
        {
            return (double)FindSum(heights) / heights.Length;
        }

        // e.find shortest height
        public static int FindShortest(int[] heights)
        {
            int min = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                min = Math.Min(min, heights[i]);
            }
            return min;
        }

        // f. find tallest height
        public static int FindTallest(int[] heights)
        {
            int max = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                max = Math.Max(max, heights[i]);
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] heights = GenerateHeights();

            Console.WriteLine("Heights of football players (cm):");
            foreach (int h in heights)
            {
                Console.Write(h + " ");
            }

            Console.WriteLine();

            int sum = FindSum(heights);
            double mean = FindMean(heights);
            int shortest = FindShortest(heights);
            int tallest = FindTallest(heights);

            Console.WriteLine("Sum of heights: " + sum);
            Console.WriteLine("Mean height: " + Math.Round(mean, 2));
            Console.WriteLine("Shortest height: " + shortest);
            Console.WriteLine("Tallest height: " + tallest);
        }
    }
}
