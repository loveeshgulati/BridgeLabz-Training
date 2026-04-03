using System;
class Perimeter{
	static void Main(String[] args){
	Console.Write("Enter Length:");
	int length = Convert.ToInt32(Console.ReadLine());
	Console.Write("Enter Width:");
	int width = Convert.ToInt32(Console.ReadLine());
	int perimeter = 2*(length + width);
	Console.WriteLine("Perimeter : "+perimeter);
	}
}