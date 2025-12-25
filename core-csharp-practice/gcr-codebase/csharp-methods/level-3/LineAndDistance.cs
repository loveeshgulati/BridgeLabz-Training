using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods.level_3
{
    public class LineAndDistance
    {
        // Find Euclidean distance 
        static double FindDistance(double x1, double y1, double x2, double y2)
        {
            double xDiff = x2 - x1;
            double yDiff = y2 - y1;

            return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        }

        // Find slope (m) and y-intercept (b) of the line
        static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            double slope = (y2 - y1) / (x2 - x1);
            double intercept = y1 - slope * x1;

            return new double[] { slope, intercept };
        }

        static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // distance
            double distance = FindDistance(x1, y1, x2, y2);

            // line equation
            double[] line = FindLineEquation(x1, y1, x2, y2);

            Console.WriteLine();
            Console.WriteLine("Euclidean Distance between points: " + Math.Round(distance, 2));
            Console.WriteLine("Equation of the line:");
            Console.WriteLine("y = " + Math.Round(line[0], 2) + "x + " + Math.Round(line[1], 2));
        }
    }
}
