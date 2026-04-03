
using System;
class Simpleinterest {
	static void Main(String[] args){
		Console.Write("Enter principal:");
		Double principal = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Rate:");
		Double rate = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Time:");
		Double time = Convert.ToDouble(Console.ReadLine());
		
		Double simpleinterest = (principal * rate * time) / 100;
		Console.WriteLine("Simple Interset : "+simpleinterest);
		
	}
}