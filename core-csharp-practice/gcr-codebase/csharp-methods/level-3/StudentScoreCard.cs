using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods.level_3
{
    public class StudentScoreCard
    {
        // b. Generate random 2-digit PCM scores
        static int[,] GeneratePCMScores(int studentCount)
        {
            int[,] scores = new int[studentCount, 3]; // Physics, Chemistry, Maths
            Random random = new Random();

            for (int i = 0; i < studentCount; i++)
            {
                scores[i, 0] = random.Next(10, 100); // Physics
                scores[i, 1] = random.Next(10, 100); // Chemistry
                scores[i, 2] = random.Next(10, 100); // Maths
            }

            return scores;
        }

        // c. Calculate total, average and percentage
        static double[,] CalculateResults(int[,] scores)
        {
            int students = scores.GetLength(0);
            double[,] results = new double[students, 3]; // Total, Average, Percentage

            for (int i = 0; i < students; i++)
            {
                int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double average = total / 3.0;
                double percentage = (total / 300.0) * 100;

                results[i, 0] = total;
                results[i, 1] = Math.Round(average, 2);
                results[i, 2] = Math.Round(percentage, 2);
            }

            return results;
        }

        // d. Display scorecard
        static void DisplayScoreCard(int[,] scores, double[,] results)
        {
            Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");

            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.WriteLine((i + 1) + "\t" +scores[i, 0] + "\t" +scores[i, 1] + "\t\t" +scores[i, 2] + "\t" +results[i, 0] + "\t" +results[i, 1] + "\t" +results[i, 2]);
            }
        }

        static void Main(string[] args)
        {
            // a. Take number of students
            Console.Write("Enter number of students: ");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            // Generate scores
            int[,] scores = GeneratePCMScores(studentCount);

            // Calculate total, average and percentage
            double[,] results = CalculateResults(scores);

            // Display scorecard
            DisplayScoreCard(scores, results);
        }
    }
}
