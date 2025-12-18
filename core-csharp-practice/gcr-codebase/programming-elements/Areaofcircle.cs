using System;
class Areaofcircle {
	static void Main(String[] args){
		Console.Write("Enter radius:");
		Double radius = Convert.ToDouble(Console.ReadLine());
		Double area = Math.PI*(radius*radius);
		Console.WriteLine("Area : "+area);
		
	}
}