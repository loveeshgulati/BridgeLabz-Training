using System;
class Addnumbers{
	static void Main(String[] args){
	Console.Write("Enter First Number:");
	int num1 = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter Second Number:");
	int num2 = Convert.ToInt32(Console.ReadLine());
	int sum = num1 + num2;
	Console.WriteLine("Sum : "+sum);
	}
}