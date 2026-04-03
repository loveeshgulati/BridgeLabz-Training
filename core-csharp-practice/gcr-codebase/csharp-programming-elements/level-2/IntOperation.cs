using System;

public class IntOperation{
     static void Main(string[] args){
        Console.Write("Enter a : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter c : ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The results of DoubleOperation are " + (a + b * c) + ", " + (a * b + c) + ", " + (c + a / b) + ", " + (a % b + c));
    }
}