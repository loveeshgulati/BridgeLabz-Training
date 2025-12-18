using System;
class Conversion {
	static void Main(String[] args){
		Console.Write("Enter Temperture in Celsius");
		int celsius = Convert.ToInt32(Console.ReadLine());
		int farenheit = (celsius * 9/5) + 32;
		Console.WriteLine("Temperature in Farenheit"+ farenheit);
		
	}
}