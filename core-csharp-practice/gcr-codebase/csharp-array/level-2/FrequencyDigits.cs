using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.Practice
{
     class FrequencyDigits
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Convert input to integer to remove any leading zeros
            int number = int.Parse(input);

            // Step 1: Count digits in the number
            int temp = number;
            int count = 0;

            while (temp > 0)
            {
                count++;
                temp /= 10;
            }

            // Step 2: Store digits in an array
            int[] digits = new int[count];
            temp = number;

            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }

            // Step 3: Frequency array of size 10
            int[] frequency = new int[10];

            // Count frequency
            foreach (int digit in digits)
            {
                frequency[digit]++;
            }

            // Step 4: Display frequency
            Console.WriteLine("\nDigit Frequencies:");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine($"Digit {i}: {frequency[i]} time(s)");
                }
            }
        }
    }
}
