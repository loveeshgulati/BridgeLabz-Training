using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods.level_3
{
    public class EmployeeBonus
    {
        // b. Generate random salary and years of service
        static double[,] GenerateEmployeeData(int count)
        {
            double[,] data = new double[count, 2]; // [salary, yearsOfService]
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                data[i, 0] = random.Next(10000, 100000); // 5-digit salary
                data[i, 1] = random.Next(1, 11);         // years of service (1–10)
            }

            return data;
        }

        // c. Calculate bonus and new salary
        static double[,] CalculateBonusAndNewSalary(double[,] employeeData)
        {
            int count = employeeData.GetLength(0);
            double[,] updatedData = new double[count, 2]; // [newSalary, bonus]

            for (int i = 0; i < count; i++)
            {
                double salary = employeeData[i, 0];
                double years = employeeData[i, 1];

                double bonusRate = years > 5 ? 0.05 : 0.02;
                double bonus = salary * bonusRate;
                double newSalary = salary + bonus;

                updatedData[i, 0] = newSalary;
                updatedData[i, 1] = bonus;
            }

            return updatedData;
        }

        // d. Calculate totals and display results
        static void DisplaySummary(double[,] oldData, double[,] newData)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;

            Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");

            for (int i = 0; i < oldData.GetLength(0); i++)
            {
                double oldSalary = oldData[i, 0];
                double years = oldData[i, 1];
                double bonus = newData[i, 1];
                double newSalary = newData[i, 0];

                totalOldSalary += oldSalary;
                totalNewSalary += newSalary;
                totalBonus += bonus;

                Console.WriteLine((i + 1) + "\t" +oldSalary + "\t\t" +years + "\t" +Math.Round(bonus, 2) + "\t\t" +Math.Round(newSalary, 2));
            }

            Console.WriteLine("Total Old Salary : " + Math.Round(totalOldSalary, 2));
            Console.WriteLine("Total Bonus Paid : " + Math.Round(totalBonus, 2));
            Console.WriteLine("Total New Salary : " + Math.Round(totalNewSalary, 2));
        }

        static void Main(string[] args)
        {
            int employeeCount = 10;

            // Generate salary and service data
            double[,] employeeData = GenerateEmployeeData(employeeCount);

            // Calculate bonus and new salary
            double[,] updatedData = CalculateBonusAndNewSalary(employeeData);

            // Display final summary
            DisplaySummary(employeeData, updatedData);
        }
    }


}
