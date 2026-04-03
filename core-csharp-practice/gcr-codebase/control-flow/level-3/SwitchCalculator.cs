using System;

class SwitchCalculator{
    static void Main(string[] args){
        Console.WriteLine("Enter first number:");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter operator (+, -, *, /):");
        string op = Console.ReadLine();

        double result = 0;
        bool isValid = true;
        switch (op){
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                result = first / second;
                break;
            default:
                Console.WriteLine("Invalid Operator");
                isValid = false;
                break;
        }

        if (isValid)
        {
            Console.WriteLine("Result: " + result);
        }
    }
}