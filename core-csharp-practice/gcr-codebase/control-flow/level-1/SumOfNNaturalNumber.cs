using System;
class SumOfNNaturalNumber{
    static void Main(String [] args){
        Console.Write("Enter a number ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0){
            int total = 0;
            int i = 1;

            while (i <= number){
                total = total+ i;
                i++;
            }

            int sumByFormula = number * (number + 1) / 2;

            Console.WriteLine("Sum using while loop: " + total);
            Console.WriteLine("Sum using formula: " + sumByFormula);

            if (total == sumByFormula)
            {
                Console.WriteLine("Both results are correct and equal.");
            }
            else
            {
                Console.WriteLine("Results are not equal.");
            }
        }
        else
        {
            Console.WriteLine("The number " + number + " is not a natural number.");
        }
    }
}