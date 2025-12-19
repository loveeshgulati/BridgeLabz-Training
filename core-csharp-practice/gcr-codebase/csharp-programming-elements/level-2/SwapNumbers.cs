using System;
class SwapNumbers{
    static void Main(string[] args){
        Console.Write("Enter number1: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number2: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        // Swapping using a temporary variable
        double temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
