using System;
class VolumeofCylinder {
	static void Main(String[] args){
		Console.Write("Enter radius:");
		Double radius = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter height:");
		Double height = Convert.ToDouble(Console.ReadLine());
		Double volume = Math.PI*(radius*radius)*height;
		Console.WriteLine("Volume Of Cylinder : "+ volume);
		
	}
}