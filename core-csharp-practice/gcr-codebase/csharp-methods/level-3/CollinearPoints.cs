using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods.level_3
{
    public class CollinearPoints
    {
        //check collinearity using slope formula
        static bool AreCollinearUsingSlope(double x1, double y1,double x2, double y2,double x3, double y3)
        {
            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);
            return slopeAB == slopeBC && slopeBC == slopeAC;
        }

        // check collinearity using area of triangle formula
        static bool AreCollinearUsingArea(double x1, double y1,double x2, double y2, double x3, double y3)
        {
            double area = 0.5 * (x1 * (y2 - y3) +x2 * (y3 - y1) +x3 * (y1 - y2));
            return area == 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter x1:");
            double x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x2:");
            double x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x3:");
            double x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y1:");
            double y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y2:");
            double y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y3:");
            double y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Points:");
            Console.WriteLine("A (" + x1 + ", " + y1 + ")");
            Console.WriteLine("B (" + x2 + ", " + y2 + ")");
            Console.WriteLine("C (" + x3 + ", " + y3 + ")");
            Console.WriteLine();

            // Check using slope method
            bool slopeResult = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);

            // Check using area method
            bool areaResult = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("Using Slope Method: " +
                (slopeResult ? "Points are Collinear" : "Points are NOT Collinear"));

            Console.WriteLine("Using Area Method: " +
                (areaResult ? "Points are Collinear" : "Points are NOT Collinear"));
        }
    }
}
