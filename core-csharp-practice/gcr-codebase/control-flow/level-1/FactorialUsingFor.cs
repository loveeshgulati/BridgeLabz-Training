using System;

class FactorialUsingFor{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // Check for natural number
        if (number <= 0){
            Console.WriteLine("Please enter a natural number");
            return;
        }
        long factorial = 1;
        for (int i = 1; i <= number; i++){
            factorial = factorial * i;
        }
        Console.WriteLine("The factorial of " + number + " is " + factorial);
    }
}
