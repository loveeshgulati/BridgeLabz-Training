using System;

public class QuotientRemainder {
    static void Main(String[] args){
	Console.Write("Enter the Number1 : ");
	int number1 = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter the Number2 : ");
	int number2 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Quotient = " + (number1 / number2)  + " and Remainder = " + (number1 % number2));	
    }
}