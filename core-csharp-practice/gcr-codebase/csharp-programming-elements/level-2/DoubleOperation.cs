using System;

public class DoubleOperation{
    public static void Main(string[] args){
        Console.Write("Enter a : ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter b : ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter c : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The results of DoubleOperation are " + (a + b * c) + ", " + (a * b + c) + ", " + (c + a / b) + ", " + (a % b + c));
    }
}